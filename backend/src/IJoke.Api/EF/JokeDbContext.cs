using IJoke.Api.EF.Config;
using IJoke.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace IJoke.Api.EF;

public class JokeDbContext(DbContextOptions<JokeDbContext> options) : DbContext(options)
{
    public DbSet<Joke> Joke { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new JokeConfiguration());
    }
}