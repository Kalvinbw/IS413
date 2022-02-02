using System;
using Microsoft.EntityFrameworkCore;

namespace mission4.Models
{
    public class MovieFormContext : DbContext
    {
        // Constructor
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<MovieForm> Responses { get; set; }

        public DbSet<Category> Categories { get; set; }

        // Seed the DB
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Romance" },
                new Category { CategoryID = 4, CategoryName = "Indie" },
                new Category { CategoryID = 5, CategoryName = "Horror" }

            );

            mb.Entity<MovieForm>().HasData(
                new MovieForm
                {
                    MovieId = 1,
                    CategoryID = 1,
                    Title = "Avengers, The",
                    Year = 2012,
                    Director = "Joss Whedon",
                    Rating = "PG-13"

                },
                new MovieForm
                {
                    MovieId = 2,
                    CategoryID = 1,
                    Title = "Matrix, The",
                    Year = 1999,
                    Director = "The Wachowski Brothers",
                    Rating = "R",
                    Edited = true
                },
                new MovieForm
                {
                    MovieId = 3,
                    CategoryID = 1,
                    Title = "Die Hard",
                    Year = 1988,
                    Director = "John McTiernan",
                    Rating = "R"
                }

              );
        }
    }
}
