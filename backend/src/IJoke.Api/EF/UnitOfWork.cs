using IJoke.Api.Abstractions;

namespace IJoke.Api.EF;

public class UnitOfWork(JokeDbContext dbContext) : IUnitOfWork
{
    public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}