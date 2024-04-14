using IJoke.Api.Abstractions;
using IJoke.Api.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace IJoke.Api.Controllers;

[ApiController]
[Route("api")]
public class JokeController(IJokeService jokeService) : ControllerBase
{
    [HttpGet("jokes")]
    public async Task<IActionResult> GetAllJokes(CancellationToken cancellationToken)
    {
        var jokes = await jokeService.GetAllJokes(cancellationToken);
        return Ok(jokes);
    }


    [HttpPost("jokes")]
    public async Task<IActionResult> CreateJoke([FromBody] CreateJokeDto jokeDto, CancellationToken cancellationToken)
    {
        await jokeService.CreateNewJoke(jokeDto, cancellationToken);
        return Created();
    }
}