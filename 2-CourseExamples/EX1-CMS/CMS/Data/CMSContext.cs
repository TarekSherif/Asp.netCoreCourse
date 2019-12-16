using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DotNetCore.Models;

namespace DotNetCore.Models
{
    public class CMSContext : DbContext
    {
        public CMSContext (DbContextOptions<CMSContext> options)
            : base(options)
        {
        }

        public DbSet<DotNetCore.Models.Category> Category { get; set; }

        public DbSet<DotNetCore.Models.Post> Post { get; set; }
    }
}
