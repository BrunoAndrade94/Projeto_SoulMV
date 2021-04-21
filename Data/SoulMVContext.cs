using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SoulMV.Models;

namespace SoulMV.Data
{
    public class SoulMVContext : DbContext
    {
        public SoulMVContext (DbContextOptions<SoulMVContext> options)
            : base(options)
        {
        }

        public DbSet<SoulMV.Models.Estoque> Estoque { get; set; }

        public DbSet<SoulMV.Models.Produto> Produto { get; set; }
    }
}
