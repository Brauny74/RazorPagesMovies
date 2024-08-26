using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovies.Data;
using System;
using System.Linq;

namespace RazorPagesMovies.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMoviesContext
                (serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMoviesContext>
                    >()))
            {
                if (context.Movie.Any())
                    return;

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Назад в будущее",
                        ReleaseDate = DateTime.Parse("1985-7-3"),
                        Genre = "фантастика",
                        Prince = 500.0m,
                        Rating="12+"
                    },
                    new Movie
                    { 
                        Title = "Назад в будущее 2",
                        ReleaseDate = DateTime.Parse("1989-11-22"),
                        Genre = "фантастика",
                        Prince = 500.0m,
                        Rating="12+"
                    },
                    new Movie
                    {
                        Title = "Назад в будущее 3",
                        ReleaseDate = DateTime.Parse("1990-5-25"),
                        Genre = "фантастика",
                        Prince = 500.0m,
                        Rating="12+"
                    },
                    new Movie
                    {
                        Title = "Охотники за приведениями",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "комедия",
                        Prince = 560.0m,
                        Rating = "0+"
                    },
                    new Movie
                    {
                        Title = "Охотники за приведениями 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "комедия",
                        Prince = 560.0m,
                        Rating = "0+"
                    },
                    new Movie
                    {
                        Title = "Роки",
                        ReleaseDate = DateTime.Parse("1976-12-3"),
                        Genre = "спортивная драма",
                        Prince = 470.0m,
                        Rating = "16+"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
