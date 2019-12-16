using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore.Models
{
    public class ParkContext : DbContext
    {
        public ParkContext(DbContextOptions<ParkContext> options)
            : base(options)
        {
        }

        public DbSet<DotNetCore.Models.Park> Parks { get; set; }
        public DbSet<DotNetCore.Models.Place> Places { get; set; }
    }
}
