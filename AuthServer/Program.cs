using Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

DatabaseManager.Initialize();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();