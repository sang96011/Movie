/// <summary>
/// In the Package Manager Console window at the PM> prompt enter
/// + Enable-Migrations -ContextTypeName MvcMovie.Models.MovieDBContext
/// create the initial migration
/// + add-migration Initial
/// create database and run Seed method
/// + update-database
///
/// Validation
/// + add-migration DataAnnotations -> update-database
///
/// 
/// </summary>

namespace Movie.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Movie.Models.FilmDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Movie.Models.FilmDBContext context)
        {
            // This code assumes that titles are unique
            context.Films.AddOrUpdate(i => i.Title,
               new Film
               {
                   Title = "When Harry Met Sally",
                   ReleaseDate = DateTime.Parse("1989-1-11"),
                   Genre = "Romantic Comedy",
                   Rating = "PG",
                   Price = 7.99M
               },

                new Film
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 8.99M
                },

                new Film
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 9.99M
                },

              new Film
              {
                  Title = "Rio Bravo",
                  ReleaseDate = DateTime.Parse("1959-4-15"),
                  Genre = "Western",
                  Rating = "PG",
                  Price = 3.99M
              }
          );

        }
    }
}
