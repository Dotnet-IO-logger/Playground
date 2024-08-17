using Example2AspnetEndpointLoggingSample;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// TODO: 1. Add HttpLogging to the services collection
//builder.Services.AddHttpLogging(options => 
//{
//    options.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.All;
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// TODO: 2. Add HttpLogging to the request pipeline
//app.UseHttpLogging();

app.UseHttpsRedirection();

app.MapGet("/hello-world", () => "Hello World!");

app.MapGet("/get-sample/{routeParam}", 
    ([FromRoute] int routeParam,
    [FromQuery] string queryParam) => 
    {
        return new 
        {
            RouteParam = routeParam,
            QueryParam = queryParam
        };
    });

app.MapPost("post-sample", ([FromBody] DummyDto bodyParam) => 
{
    return bodyParam;
});

app.MapPut("put-sample/{routeParam}", 
    ([FromRoute] int routeParam,
    [FromHeader] string headerParam) => 
    {
        return new
        {
            RouteParam = routeParam,
            HeaderParam = headerParam
        };
    });

app.MapPatch("patch-sample/{routeParam}", 
    ([FromRoute] int routeParam) =>
    {
        return routeParam;
    });

app.MapDelete("delete-sample/{routeParam}", 
    ([FromRoute] int routeParam) => 
    {
        return routeParam; 
    });

app.Run();