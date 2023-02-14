using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_ena0920.Models
{
    public class MovieCollectionContext : System.Data.Entity.DbContext

    {
        public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options) : base(options)
        {
            //Leave blank for now
        }

        public System.Data.Entity.DbSet<ApplicationResponse> responses { get; set; }
    }
}
