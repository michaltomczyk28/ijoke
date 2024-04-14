using IJoke.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IJoke.Api.EF.Config;

internal class JokeConfiguration : IEntityTypeConfiguration<Joke>
{
    public void Configure(EntityTypeBuilder<Joke> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasData(
            new Joke()
            {
                Id = Guid.NewGuid(),
                Content = @"Dyrektor do swojego pracownika:
- Z pana to byłby doskonały przestępca...
- Dlaczego?
- Bo nie zostawia pan żadnych śladów swojej działalności...",
                AuthorName = "Frezja26 (dowcipy.jeja.pl)",
                Votes = 0,
                CreatedAt = DateTime.UtcNow
            },
            new Joke()
            {
                Id = Guid.NewGuid(),
                Content = @"- Jesteście matołami! 80% z was nie ma pojęcia o matematyce! - krzyczy nauczyciel.
- No bez przesady! Tylu to nas nawet nie ma w klasie!",
                AuthorName = "Cziszczus (dowcipy.jeja.pl)",
                Votes = 0,
                CreatedAt = DateTime.UtcNow
            },
            new Joke()
            {
                Id = Guid.NewGuid(),
                Content = @"Rozmowa telefoniczna dwóch kolegów stolarzy:
- Cześć, co robisz?
- Krzesło dla teściowej.
- A dużo Ci jeszcze zostało do zrobienia? Może na flaszkę wpadniesz?
- Ok. Nie ma problemu. Podłączę tylko przewody i jestem...",
                AuthorName = "Polymorphism1 (dowcipy.jeja.pl)",
                Votes = 0,
                CreatedAt = DateTime.UtcNow
            }
        );
    }
}