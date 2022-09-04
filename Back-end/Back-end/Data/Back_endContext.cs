using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Back_end.Models;

namespace Back_end.Data
{
    public class Back_endContext : DbContext
    {
        public Back_endContext (DbContextOptions<Back_endContext> options)
            : base(options)
        {
        }

        public DbSet<Back_end.Models.Product> Product { get; set; }
    }
}
