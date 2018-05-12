using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using AstroPod.Models;

namespace AstroPod.Models
{


    public class AstroPodDbContext : IdentityDbContext<AppUser>
    {








        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseMySql(Startup.ConnectionString);

        public AstroPodDbContext(DbContextOptions<AstroPodDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}