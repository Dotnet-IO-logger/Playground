var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// TODO: 1. Add HttpClient
//builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/bing", async (HttpClient httpClient) =>
{
    // TODO: 5. Add custom request headers
    //httpClient.DefaultRequestHeaders.Add("my-header-name", "my-header-value");

    // TODO: 2. Call an external service
    //var response = await httpClient.GetAsync("https://www.bing.com");

    // TODO: 3. Return the status code
    //return response.StatusCode;
});

app.Run();