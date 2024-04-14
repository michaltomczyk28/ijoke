using IJoke.Api.Entities;

namespace IJoke.Api.Services;

public interface IJokeRepository
{
    Task<IEnumerable<Joke>> FindAllAsync(CancellationToken cancellationToken);
}