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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieForm>().HasData(
                new MovieForm
                {
                    MovieId = 1,
                    Category = "Action/Adventure",
                    Title = "Avengers, The",
                    Year = 2012,
                    Director = "Joss Whedon",
                    Rating = "PG-13"

                },
                new MovieForm
                {
                    MovieId = 2,
                    Category = "Action/Adventure",
                    Title = "Matrix, The",
                    Year = 1999,
                    Director = "The Wachowski Brothers",
                    Rating = "R",
                    Edited = true
                },
                new MovieForm
                {
                    MovieId = 3,
                    Category = "Action/Adventure",
                    Title = "Die Hard",
                    Year = 1988,
                    Director = "John McTiernan",
                    Rating = "R"
                }

              );
        }
    }
}
