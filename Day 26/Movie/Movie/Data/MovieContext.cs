using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movie.Model;

namespace Movie.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie.Model.Movie> Movie { get; set; } = default!;
    }
}
