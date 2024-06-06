using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Baahubali",
                    ReleaseDate = DateTime.Parse("2012-08-28"),
                    Genre = "Drama",
                    Price = 7.99M,
                    Rating = "4.0"
                },
                new Movie
                {
                    Title = "Mirchi ",
                    ReleaseDate = DateTime.Parse("2009-11-28"),
                    Genre = "Love Action",
                    Price = 8.99M,
                    Rating = "4.0"
                },
                new Movie
                {
                    Title = "Baahubali 2",
                    ReleaseDate = DateTime.Parse("2015-08-25"),
                    Genre = "Drama",
                    Price = 9.99M,
                    Rating = "4.0"
                },
                new Movie
                {
                    Title = "Darling",
                    ReleaseDate = DateTime.Parse("2008-10-11"),
                    Genre = "Love",
                    Price = 3.99M,
                    Rating = "4.0"
                },
                new Movie
                {
                    Title = "Aavesham",
                    ReleaseDate = DateTime.Parse("2024-04-25"),
                    Genre = "Action Comedy",
                    Price = 7.99M,
                    Rating = "4.0"
                }
            );
            context.SaveChanges();
        }
    }
}