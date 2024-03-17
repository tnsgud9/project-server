using ApiServer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHealthChecks();

var config = new Config(builder.Configuration);
// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddSingleton(config);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
