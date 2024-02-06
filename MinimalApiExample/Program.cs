using Carter;
using Microsoft.EntityFrameworkCore;
using MinimalApiExample.Contexts;
using MinimalApiExample.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCarter();
builder.Services.AddDbContext<AppDbContext>(opts =>
{
	opts.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
var app = builder.Build();

app.MapCarter();
//app.MapGet("/", () => "ok");

app.Run();
