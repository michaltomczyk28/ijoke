﻿// <auto-generated />
using System;
using IJoke.Api.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IJoke.Api.EF.Migrations
{
    [DbContext(typeof(JokeDbContext))]
    [Migration("20240414133832_CreateJokeTable")]
    partial class CreateJokeTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("IJoke.Api.Entities.Joke", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Votes")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Joke");

                    b.HasData(
                        new
                        {
                            Id = new Guid("43629dc3-92ab-4e69-8f12-7e3d19e5614b"),
                            AuthorName = "Frezja26 (dowcipy.jeja.pl)",
                            Content = "Dyrektor do swojego pracownika:\n- Z pana to byłby doskonały przestępca...\n- Dlaczego?\n- Bo nie zostawia pan żadnych śladów swojej działalności...",
                            CreatedAt = new DateTime(2024, 4, 14, 13, 38, 31, 956, DateTimeKind.Utc).AddTicks(7460),
                            Votes = 0
                        },
                        new
                        {
                            Id = new Guid("a59351ec-920a-4081-87a2-e1649d3acfde"),
                            AuthorName = "Cziszczus (dowcipy.jeja.pl)",
                            Content = "- Jesteście matołami! 80% z was nie ma pojęcia o matematyce! - krzyczy nauczyciel.\n- No bez przesady! Tylu to nas nawet nie ma w klasie!",
                            CreatedAt = new DateTime(2024, 4, 14, 13, 38, 31, 956, DateTimeKind.Utc).AddTicks(7460),
                            Votes = 0
                        },
                        new
                        {
                            Id = new Guid("6d1f687b-b883-47f3-8ec6-582700973c56"),
                            AuthorName = "Polymorphism1 (dowcipy.jeja.pl)",
                            Content = "Rozmowa telefoniczna dwóch kolegów stolarzy:\n- Cześć, co robisz?\n- Krzesło dla teściowej.\n- A dużo Ci jeszcze zostało do zrobienia? Może na flaszkę wpadniesz?\n- Ok. Nie ma problemu. Podłączę tylko przewody i jestem...",
                            CreatedAt = new DateTime(2024, 4, 14, 13, 38, 31, 956, DateTimeKind.Utc).AddTicks(7470),
                            Votes = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
