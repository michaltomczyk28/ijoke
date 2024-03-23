using Microsoft.EntityFrameworkCore;

namespace IJoke.Api.EF;

public class JokeDbContext : DbContext
{
    public JokeDbContext(DbContextOptions<JokeDbContext> options) : base(options)
    {
    }
}