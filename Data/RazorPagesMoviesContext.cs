using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovies.Models;

namespace RazorPagesMovies.Data
{
    public class RazorPagesMoviesContext : DbContext
    {
        public RazorPagesMoviesContext (DbContextOptions<RazorPagesMoviesContext> options)
            : base(options)
        {
        }
        /*
         * Add-Migration InitialCreate
         * Update-Database
         * https://bpa.st/52OA
         */
        public DbSet<RazorPagesMovies.Models.Movie> Movie { get; set; } = default!;
    }
}
