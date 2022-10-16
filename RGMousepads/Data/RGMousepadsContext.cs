using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RGMousepads.Models;

namespace RGMousepads.Data
{
    public class RGMousepadsContext : DbContext
    {
        public RGMousepadsContext (DbContextOptions<RGMousepadsContext> options)
            : base(options)
        {
        }

        public DbSet<RGMousepads.Models.MousepadsClass> MousepadsClass { get; set; }
    }
}
