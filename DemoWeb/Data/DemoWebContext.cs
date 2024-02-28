using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoWeb.Models;

namespace DemoWeb.Data
{
    public class DemoWebContext : DbContext
    {
        public DemoWebContext (DbContextOptions<DemoWebContext> options)
            : base(options)
        {
        }

        public DbSet<DemoWeb.Models.Employee> Employee { get; set; }
    }
}
