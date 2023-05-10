using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HelloWorldWebApp.Models;

namespace HelloWorldWebApp.Data
{
    public class HelloWorldWebAppContext : DbContext
    {
        public HelloWorldWebAppContext (DbContextOptions<HelloWorldWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<HelloWorldWebApp.Models.Movie> Movie { get; set; } = default!;
    }
}
