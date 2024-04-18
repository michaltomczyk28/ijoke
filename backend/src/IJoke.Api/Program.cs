using IJoke.Api.Abstractions;
using IJoke.Api.EF;
using IJoke.Api.EF.Repositories;
using IJoke.Api.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<JokeDbContext>(
    options => options.UseNpgsql("name=ConnectionStrings:JokeCS"));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontendDevClient",
        builder =>
        {
            builder
                .WithOrigins("http://localhost:5173")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IJokeRepository, JokeRepository>();
builder.Services.AddScoped<IJokeService, JokeService>();

var app = builder.Build();

app.UseCors("AllowFrontendDevClient");
app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapControllers();

// Run database migrations
using (var serviceScope = app.Services.CreateScope())
{
    var dbContext = serviceScope.ServiceProvider.GetRequiredService<JokeDbContext>();
    dbContext.Database.Migrate();
}

app.Run();