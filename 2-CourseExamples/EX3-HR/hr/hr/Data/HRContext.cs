using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using hr.Models;

namespace hr.Models
{
    public class HRContext : DbContext
    {
        public HRContext (DbContextOptions<HRContext> options)
            : base(options)
        {
        }

        public DbSet<hr.Models.Dept> Dept { get; set; }

        public DbSet<hr.Models.Emp> Emp { get; set; }
    }
}
