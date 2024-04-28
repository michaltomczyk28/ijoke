using IJoke.Api.Entities;

namespace IJoke.Api.Services;

public interface IJokeRepository
{
    void Update(Joke joke);
    void Add(Joke joke);
    Task<IEnumerable<Joke>> FindAllAsync(CancellationToken cancellationToken);
    Task<Joke?> FindByIdAsync(Guid id, CancellationToken cancellationToken);
}