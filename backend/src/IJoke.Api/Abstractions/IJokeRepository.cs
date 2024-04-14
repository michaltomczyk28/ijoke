using IJoke.Api.Entities;

namespace IJoke.Api.Services;

public interface IJokeRepository
{
    void Add(Joke joke);
    Task<IEnumerable<Joke>> FindAllAsync(CancellationToken cancellationToken);
}