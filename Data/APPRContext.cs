using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APPR.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace APPR.Data
{
    public class APPRContext : IdentityDbContext
    {
        public APPRContext (DbContextOptions<APPRContext> options)
            : base(options)
        {
        }

        public DbSet<APPR.Models.Category> Category { get; set; } = default!;

        public DbSet<APPR.Models.DisasDon>? DisasDon { get; set; }

        public DbSet<APPR.Models.goodAlloc>? goodAlloc { get; set; }

        public DbSet<APPR.Models.GoodDon>? GoodDon { get; set; }

        public DbSet<APPR.Models.monAlloc>? monAlloc { get; set; }

        public DbSet<APPR.Models.monDon>? monDon { get; set; }

        public DbSet<APPR.Models.purchas>? purchas { get; set; }
    }
}
