using IJoke.Api.Dtos;

namespace IJoke.Api.Abstractions;

public interface IJokeService
{
    Task CreateNewJoke(CreateJokeDto jokeDto, CancellationToken cancellationToken = default);
    Task<IEnumerable<JokeDto>> GetAllJokes(CancellationToken cancellationToken = default);
}