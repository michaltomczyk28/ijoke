namespace IJoke.Api.Entities;

public class Joke
{
    public Guid Id { get; set; }
    public string Content { get; set; }
    public string AuthorName { get; set; }
    public int Votes { get; set; }
    public DateTime CreatedAt { get; set; }
}