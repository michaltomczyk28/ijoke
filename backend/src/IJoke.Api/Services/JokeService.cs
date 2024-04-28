using IJoke.Api.Abstractions;
using IJoke.Api.Dtos;
using IJoke.Api.Entities;

namespace IJoke.Api.Services;

internal class JokeService(IJokeRepository jokeRepository, IUnitOfWork unitOfWork) : IJokeService
{
    public async Task CreateNewJoke(CreateJokeDto jokeDto, CancellationToken cancellationToken = default)
    {
        var joke = new Joke()
        {
            AuthorName = jokeDto.AuthorName,
            Content = jokeDto.Content,
            CreatedAt = DateTime.UtcNow,
            Votes = 0
        };
        
        jokeRepository.Add(joke);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

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

    public async Task AddVote(VoteDto voteDto, CancellationToken cancellationToken = default)
    {
        var joke = await jokeRepository.FindByIdAsync(voteDto.JokeId, cancellationToken);
        if (joke is null)
        {
            throw new Exception("Joke not found");
        }
        
        int multiplier = voteDto.IsUpvote ? 1 : -1;
        joke.Votes += 1 * multiplier;
        
        jokeRepository.Update(joke);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}