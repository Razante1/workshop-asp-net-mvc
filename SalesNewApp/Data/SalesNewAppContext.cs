using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesNewApp.Models
{
    public class SalesNewAppContext : DbContext
    {
        public SalesNewAppContext (DbContextOptions<SalesNewAppContext> options)
            : base(options)
        {
        }

        public DbSet<SalesNewApp.Models.Department> Department { get; set; } = default!;
    }
}
