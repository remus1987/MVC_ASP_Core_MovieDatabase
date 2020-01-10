using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Movie_ASPCore.Models;

namespace MVC_Movie_ASPCore.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Movie_ASPCore.Models.Movie> Movie { get; set; }
    }
}
