using IJoke.Api.Services;
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
}