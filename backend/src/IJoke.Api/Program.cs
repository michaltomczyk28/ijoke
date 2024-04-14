using IJoke.Api.EF;
using IJoke.Api.EF.Repositories;
using IJoke.Api.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<JokeDbContext>(
    options => options.UseNpgsql("name=ConnectionStrings:JokeCS"));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IJokeRepository, JokeRepository>();
builder.Services.AddScoped<IJokeService, JokeService>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();