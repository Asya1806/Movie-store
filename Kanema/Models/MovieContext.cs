using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanema.Models
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasKey(u => u.Id);
            modelBuilder.Entity<Category>().HasKey(u => u.Id);

            var category = new List<Category>
                {
                    new Category{ Id = 1, CategoryName = "Фильмы", Description = "Все виды фильмов" },
                    new Category{ Id = 2, CategoryName = "Сериалы", Description = "Многосерийные фильмы" },
                    new Category{ Id = 3, CategoryName = "Мультфильмы", Description = "Анимированные фильмы" },
                    new Category{ Id = 4, CategoryName = "Аниме", Description = "Многосерийные мультфильмы" }
                };
            modelBuilder.Entity<Category>().HasData(category);

            base.OnModelCreating(modelBuilder);
        }
    }
}
