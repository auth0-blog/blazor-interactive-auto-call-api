var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication().AddJwtBearer();
builder.Services.AddAuthorization();

builder.Services.AddSwaggerService();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseStaticFiles();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/data", () =>
{
    var data = Enumerable.Range(1, 5).Select(index =>
        Random.Shared.Next(1, 100))
        .ToArray();

    return data;
})
.WithName("GetWeatherForecast")
.RequireAuthorization()
.WithOpenApi();

app.MapFallbackToFile("index.html");

app.Run();
