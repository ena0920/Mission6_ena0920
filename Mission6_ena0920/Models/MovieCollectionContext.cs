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

        public Microsoft.EntityFrameworkCore.DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Action/Adventure"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Comedy"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Drama"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Family"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Horror/Suspense"
                },
                new Category
                {
                    CategoryID = 6,
                    CategoryName = "Miscellaneous"
                },
                new Category
                {
                    CategoryID = 7,
                    CategoryName = "Television"
                },
                new Category
                {
                    CategoryID = 8,
                    CategoryName = "VHS"
                }
                );
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    ApplicationID = 1,
                    CategoryID = 4,
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
                    CategoryID = 2,          
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
                    CategoryID = 6,          
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
