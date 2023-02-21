using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_ena0920.Models
{
    public class MovieCollectionContext : Microsoft.EntityFrameworkCore.DbContext

    {
        public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options) : base(options)
        {
            //Leave blank for now
        }

        public Microsoft.EntityFrameworkCore.DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    ApplicationID = 1,
                    Category = "Fantasy",
                    Title = "Encanto",
                    Year = 2021,
                    Director = "Jared Bush",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "Emma Antonucci"

                },
                new ApplicationResponse
                {
                    ApplicationID = 2,
                    Category = "Crime Comedy",
                    Title = "Raising Arizona",
                    Year = 1987,
                    Director = "Ethan Coen",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "Camilla Antonucci"
                },
                new ApplicationResponse
                {
                    ApplicationID = 3,
                    Category = "Biographical",
                    Title = "Hidden Figures",
                    Year = 2017,
                    Director = "Theodore Melfi",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "Kayla Antonucci"
                }
                );
        }
    }
}
