using IJoke.Api.Abstractions;
using IJoke.Api.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace IJoke.Api.Controllers;

[ApiController]
[Route("api")]
public class VoteController(IJokeService jokeService) : ControllerBase
{
    [HttpPost("jokes/{id:guid}/votes")]
    public async Task<IActionResult> AddVote(Guid id, [FromBody] VoteDto voteDto, CancellationToken cancellationToken)
    {
        voteDto.JokeId = id;
        await jokeService.AddVote(voteDto, cancellationToken);
        
        return Created();
    }
}