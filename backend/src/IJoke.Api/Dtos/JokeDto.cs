namespace IJoke.Api.Dtos;

public class JokeDto
{
    public Guid Id { get; set; }
    public string Content { get; set; }
    public string AuthorName { get; set; }
    public int Votes { get; set; }
    public DateTime CreatedAt { get; set; }
}