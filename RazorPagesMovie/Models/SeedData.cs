using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using RazorPagesMovie.Enums;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any() && context.Customer.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R",
                        Director = "Unknown"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "R",
                        Director = "Ivan Reitman"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "R",
                        Director = "Unknown"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "R",
                        Director = "Unknown"
                    }
                );

                context.Customer.AddRange(
                    new Customer
                    {
                        EmailAddress="a1@jefe.com",
                        Salutation = Title.Mr,
                        Name ="Arnoldo",
                        Lastname= "Perozo",
                        BirthDate = DateTime.Parse("1977-3-05"),
                        Gender= 0,
                        Address="Heredia",
                        Phone="123-4567890"
                    },

                    new Customer
                    {
                        EmailAddress = "alfa@mio.com",
                        Salutation = Title.Mrs,
                        Name = "Rita",
                        Lastname = "Moreno",
                        BirthDate = DateTime.Parse("1989-10-10"),
                        Gender = Gender.Female,
                        Address = "Not Sure",
                        Phone = "123-4567890"
                    },

                    new Customer
                    {
                        EmailAddress = "beta@phone.com",
                        Salutation = Title.Miss,
                        Name = "Johanna",
                        Lastname = "Sanchez",
                        BirthDate = DateTime.Parse("1995-8-18"),
                        Gender = Gender.Female,
                        Address = "Don't Know",
                        Phone = "123-4567890"
                    });

                context.SaveChanges();
            }
        }
    }
}