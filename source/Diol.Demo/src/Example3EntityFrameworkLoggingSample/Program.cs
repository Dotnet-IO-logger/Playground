using Example3EntityFrameworkLoggingSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DiolDbContext>(options => 
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/api/categories", async (DiolDbContext dbContext) =>
{
    // TODO: 2. A simple query with SELECT
    return await dbContext.Categories.ToListAsync();
});

app.MapGet("/api/categories/{categoryId}/eventNames", 
    async (DiolDbContext dbContext, 
    [FromRoute] int categoryId) => 
    {
        // TODO: 3. An example of FILTERING and SELECTING data
        return await dbContext.EventNames
            .Where(x => x.CategoryId == categoryId)
            .ToListAsync();
    });

app.MapGet("/api/categories/{categoryId}/eventNames/{eventNameId}/logEvents",
    async (DiolDbContext dbContext,
    [FromRoute] int categoryId,
    [FromRoute] int eventNameId) =>
    {
        // TODO: 4. An example of JOINING tables and FILTERING data
        return await dbContext.EventLogs
            .Where(x => x.EventName.CategoryId == categoryId 
                && x.EventNameId == eventNameId)
            .ToListAsync();
    });

app.MapGet("/api/categories/withLogEvents", 
    async (DiolDbContext dbContext) => 
    {
        // TODO: 5. A complex query with JOIN, GROUP BY, ORDER BY
        var result = await dbContext.EventLogs
            .Include(x => x.EventName)
                .ThenInclude(x => x.Category)
            .Select(x => new 
            {
                Id = x.EventName.CategoryId,
                Name = x.EventName.Category.Name,
            })
            .GroupBy(x => new { x.Id, x.Name })
            .Select(x => new 
            {
                Id = x.Key.Id,
                Name = x.Key.Name,
                EventsAmount = x.Count()
            })
            .OrderByDescending(x => x.EventsAmount)
            .ToListAsync();

        return result;
    });

app.MapGet("/api/categories/FilteredByEventsAmountBetween", 
    async (DiolDbContext dbContext,
    [FromQuery] int min,
    [FromQuery] int max) => 
    {
        // TODO: 6. A complex query with JOIN, GROUP BY, ORDER BY and FILTERING
        var result = await dbContext.EventLogs
            .Include(x => x.EventName)
                .ThenInclude(x => x.Category)
            .Select(x => new
            {
                Id = x.EventName.CategoryId,
                Name = x.EventName.Category.Name,
            })
            .GroupBy(x => new { x.Id, x.Name })
            .Where(x => min < x.Count() && x.Count() < max)
            .Select(x => new
            {
                Id = x.Key.Id,
                Name = x.Key.Name,
                EventsAmount = x.Count()
            })
            .OrderByDescending(x => x.EventsAmount)
            .ToListAsync();

        return result;
    });

app.MapPost("/api/categories/{categoryId}/eventNames/{eventNameId}/logEvents",
    async (DiolDbContext dbContext,
    [FromRoute] int categoryId,
    [FromRoute] int eventNameId) =>
    {
        // TODO: 7. An example of multiple operations
        var eventName = await dbContext.EventNames
            .Where(x => x.CategoryId == categoryId 
                && x.Id == eventNameId)
            .FirstOrDefaultAsync();

        if (eventName == null)
        {
            throw new ArgumentException("EventName not found");
        }

        var log = new EventLog
        {
            EventNameId = eventNameId,
        };

        dbContext.EventLogs.Add(log);
        await dbContext.SaveChangesAsync();

        return log;
    });

app.MapPost("/api/categories/{categoryId}/eventNames", 
    async (DiolDbContext dbContext,
    [FromRoute] int categoryId,
    [FromBody] PostEventNameModel eventModel) =>
    {
        // TODO: 8. An example of transaction
        using var transaction = dbContext.Database.BeginTransaction();

        try 
        {
            var isEventNameExists = await dbContext.EventNames
                .AnyAsync(x => x.CategoryId == categoryId 
                    && x.Name == eventModel.EventName);

            if (isEventNameExists) 
            {
                throw new Exception($"'{eventModel.EventName}' is already exist. Try another one");
            }

            var newEventName = new EventName
            {
                Name = eventModel.EventName,
                CategoryId = categoryId,
            };

            dbContext.EventNames.Add(newEventName);
            await dbContext.SaveChangesAsync();

            var logs = Enumerable.Range(0, eventModel.AmountOfNewEventLogs)
                .Select(x => new EventLog
                {
                    EventNameId = newEventName.Id,
                });

            dbContext.EventLogs.AddRange(logs);
            await dbContext.SaveChangesAsync();

            if (eventModel.commit)
            {
                transaction.Commit();
            }
            else 
            {
                throw new Exception("Rollback is forced by a user");
            }
        }
        catch(Exception ex)
        {
            transaction.Rollback();
            throw;
        }
    });

app.Run();

public class PostEventNameModel 
{
    public string? EventName { get; set; }
    public int AmountOfNewEventLogs { get; set; }
    public bool commit { get; set; }
}