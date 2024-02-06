using Carter;
using Microsoft.EntityFrameworkCore;
using MinimalApiExample.Contexts;
using MinimalApiExample.Utilities.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCarter();
builder.Services.AddDbContext<AppDbContext>(opts =>
{
	opts.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
builder.Services.AddServices();
var app = builder.Build();

app.MapCarter();
//app.MapGet("/", () => "ok");

app.Run();
