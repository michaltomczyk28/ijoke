namespace IJoke.Api.Dtos;

public class VoteDto
{
    public Guid JokeId { get; set; }
    public bool IsUpvote { get; set; }
}