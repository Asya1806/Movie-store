using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanema.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }        

        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Role> Role { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasKey(u => u.Id);
            modelBuilder.Entity<User>().HasKey(u => u.Id);

            var admin = new Role() { Id = 1, Name = "admin" };
            var user = new Role() { Id = 2, Name = "user" };

            modelBuilder.Entity<Role>().HasData(new Role[] { admin, user });

            base.OnModelCreating(modelBuilder);
        }
    }
}
