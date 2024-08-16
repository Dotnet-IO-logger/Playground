using Diol.Playgrounds.PlaygroundApi;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 1. Add http client factory
builder.Services.AddHttpClient();

// add named http client
builder.Services.AddHttpClient("customClient", httpClient => 
{
    httpClient.DefaultRequestHeaders.Add("my-custom-header-text", "my-text");
    httpClient.DefaultRequestHeaders.Add("my-custom-header-number", $"{20240816}");
    httpClient.DefaultRequestHeaders.Add("my-custom-header-date", $"{new DateOnly(2024, 08, 16).ToShortDateString()}");
});

// 2. Add http logger for asp.net core
builder.Services.AddHttpLogging(options =>
{
    options.LoggingFields = HttpLoggingFields.All;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpLogging();

app.UseHttpsRedirection();

app.MapGet("/api/http/default-client", async (HttpClient httpClient) => 
{
    var response = await httpClient
        .GetAsync("https://www.bing.com")
        .ConfigureAwait(false);

    return response.StatusCode;
});

app.MapGet("api/http/custom-client", async (IHttpClientFactory factory) =>
{
    var httpClient = factory.CreateClient("customClient");

    var response = await httpClient
        .GetAsync("https://www.bing.com")
        .ConfigureAwait(false);

    return response.StatusCode;
});

app.MapGet("api/http/multiple-calls", 
    async (HttpClient httpClient) => 
    {
        var urls = new string[]
        {
            "https://www.bing.com",
            "https://www.google.com"
        };

        var tasks = urls.Select(url => 
            Task.Run(async () =>
            {
                var response = await httpClient
                    .GetAsync(url)
                    .ConfigureAwait(false);

                var content = await response.Content
                    .ReadAsStringAsync()
                    .ConfigureAwait(false);

                return response.StatusCode;
            }));

        var results = await Task.WhenAll(tasks)
            .ConfigureAwait(false);

        return results;
    });

app.MapGet("api/aspnet/get-logger-providers", 
    (IServiceProvider serviceProvider) =>
{
    var services = serviceProvider.GetServices<ILoggerProvider>();

    var names = services.Select(x => x.GetType().Name);

    return names;
});

app.MapGet("/api/aspnet/process-id", () =>
{
    return Process.GetCurrentProcess().Id;
});

app.MapPost("api/aspnet/with-body",
    ([FromBody] DummyModel bodyAttribute) =>
    {
        return bodyAttribute;
    });

app.MapPut("/api/aspnet/with-headers", 
    ([FromHeader] string myHeader, 
    HttpRequest request) =>
{
    request.HttpContext.Response.Headers.Add("my-response-header", $"{myHeader}");

    return myHeader;
});

app.MapPut("/api/aspnet/with-route-param/{routeAttribute}", 
    ([FromRoute] int routeAttribute) =>
{
    return routeAttribute;
});

app.MapPatch("/api/aspnet/with-query-param", 
    ([FromQuery] int queryParam) =>
{
    return queryParam;
});

app.MapDelete("/api/fail-if-negative/{id}", 
    ([FromRoute] int id) =>
{
    if (id < 0)
    {
        return Results.BadRequest(id);
    }

    return Results.Ok(id);
});

app.Run();
