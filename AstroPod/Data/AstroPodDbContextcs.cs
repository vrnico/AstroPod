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
        public virtual DbSet<AppUser> AppUser { get; set; }
        public virtual DbSet<Content> Content { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }







        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(Startup.ConnectionString);
        }

        public AstroPodDbContext(DbContextOptions<AstroPodDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


        }
    }
}