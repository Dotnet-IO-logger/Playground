using Microsoft.EntityFrameworkCore;

namespace Example3EntityFrameworkLoggingSample.Models;

public class DiolDbContext : DbContext
{
    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<EventName> EventNames { get; set; }

    public virtual DbSet<EventLog> EventLogs { get; set; }

    public DiolDbContext(DbContextOptions<DiolDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Setup initial values
        var categories = new[]
        {
            new Category { Id = 1, Name = "HttpClient", State = State.Ready },
            new Category { Id = 2, Name = "Aspnet", State = State.Ready },
            new Category { Id = 3, Name = "EntityFramework", State = State.Ready },
            new Category { Id = 4, Name = "WebSockets", State = State.ComingSoon },
            new Category { Id = 5, Name = "gRPC", State = State.ComingSoon },
        };

        var events = new[] 
        {
            // HttpClient
            new EventName { Id = 1, Name = "RequestPipelineStartDto", CategoryId = 1 },
            new EventName { Id = 2, Name = "RequestPipelineRequestHeaderDto", CategoryId = 1 },
            new EventName { Id = 3, Name = "RequestPipelineEndDto", CategoryId = 1 },
            new EventName { Id = 4, Name = "RequestPipelineResponseHeaderDto", CategoryId = 1 },

            // Aspnet
            new EventName { Id = 5, Name = "RequestLogDto", CategoryId = 2 },
            new EventName { Id = 6, Name = "RequestBodyDto", CategoryId = 2 },
            new EventName { Id = 7, Name = "ResponseLogDto", CategoryId = 2 },
            new EventName { Id = 8, Name = "ResponseBodyDto", CategoryId = 2 },

            // EntityFramework
            new EventName { Id = 9, Name = "ConnectionOpeningDto", CategoryId = 3 },
            new EventName { Id = 10, Name = "CommandExecutingDto", CategoryId = 3 },
            new EventName { Id = 11, Name = "CommandExecutedDto", CategoryId = 3 },
        };

        var rnd = new Random();

        var logs = Enumerable.Range(1, 100)
            .Select(x => new EventLog
            {
                Id = x,
                EventNameId = events[rnd.Next(events.Length)].Id
            }).ToArray();

        modelBuilder.Entity<Category>().HasData(categories);
        modelBuilder.Entity<EventName>().HasData(events);
        modelBuilder.Entity<EventLog>().HasData(logs);
    }
}

#region Models
public enum State
{
    ComingSoon = 0,
    Ready = 1,
}

public class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public State State { get; set; }

    public virtual ICollection<EventName>? EventNames { get; set; }
}

public class EventName
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? CategoryId { get; set; }
    public virtual Category? Category { get; set; }
}

public class EventLog
{
    public int Id { get; set; }

    public int? EventNameId { get; set; }
    public virtual EventName? EventName { get; set; }
}
#endregion