using System;
using Microsoft.EntityFrameworkCore;
using TasksApp.Models;

namespace TasksApp.DataAccess
{
    public class TodoDBContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Database=MyTodoDB;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(new Todo
            {
                Id = 1,
                Title = "Get Books",
                Description = "Get books for school from DB",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            });
        }
    }
}
