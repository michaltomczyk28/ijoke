using Microsoft.AspNetCore.Mvc;

namespace IJoke.Api.Controllers;

[ApiController]
[Route("jokes")]
public class JokeController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllJokes()
    {
        return Ok("Test endpoint");
    }
}