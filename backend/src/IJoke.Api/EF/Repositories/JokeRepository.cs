using IJoke.Api.Entities;
using IJoke.Api.Services;
using Microsoft.EntityFrameworkCore;

namespace IJoke.Api.EF.Repositories;

internal class JokeRepository(JokeDbContext jokeDbContext) : IJokeRepository
{
    public void Add(Joke joke)
    {
        jokeDbContext.Add(joke);
    }

    public async Task<IEnumerable<Joke>> FindAllAsync(CancellationToken cancellationToken)
    {
        return await jokeDbContext.Joke.ToListAsync(cancellationToken);
    }
}