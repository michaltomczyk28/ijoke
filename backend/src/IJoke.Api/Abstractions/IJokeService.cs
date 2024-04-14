using IJoke.Api.Dtos;

namespace IJoke.Api.Services;

public interface IJokeService
{
    Task<IEnumerable<JokeDto>> GetAllJokes(CancellationToken cancellationToken = default);
}