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
    
    public void Update(Joke joke)
    {
        jokeDbContext.Update(joke);
    }


    public async Task<IEnumerable<Joke>> FindAllAsync(CancellationToken cancellationToken)
    {
        return await jokeDbContext.Joke.ToListAsync(cancellationToken);
    }

    public async Task<Joke?> FindByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await jokeDbContext.Joke.FirstOrDefaultAsync(j => j.Id == id, cancellationToken);
    }
}