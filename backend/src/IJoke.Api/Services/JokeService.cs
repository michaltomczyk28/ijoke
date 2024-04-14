using IJoke.Api.Dtos;

namespace IJoke.Api.Services;

internal class JokeService(IJokeRepository jokeRepository) : IJokeService
{
    public async Task<IEnumerable<JokeDto>> GetAllJokes(CancellationToken cancellationToken = default)
    {
        var jokes = await jokeRepository.FindAllAsync(cancellationToken);

        return jokes.Select(j => new JokeDto()
        {
            Id = j.Id,
            AuthorName = j.AuthorName,
            Content = j.Content,
            Votes = j.Votes,
            CreatedAt = j.CreatedAt
        });
    }
}