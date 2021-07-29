using System;
using Microsoft.EntityFrameworkCore;
using TasksApp.Models;

namespace TasksApp.DataAccess
{
    public class TodoDBContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
      
            var connectionString = "Server=localhost;Database=MyTodoDB;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Author>().HasData(new Author[]{

                new Author { Id=1,FullName="Dinuwan Kalubowila",AddresNo = "45", Street = "Street 1", City="Colombo 1"},
                new Author { Id=2,FullName="Dureksha Wasala", AddresNo = "35", Street = "Street 2", City="Colombo 2"},
                new Author { Id=3,FullName="Chod Perera", AddresNo = "25", Street = "Street 3", City="Colombo 3"},
                new Author { Id=4,FullName="Chamika Visal", AddresNo = "15", Street = "Street 4", City="Colombo 4" },
            });

            modelBuilder.Entity<Todo>().HasData(new Todo[]
            {
                new Todo{
                    Id = 1,
                    Title = "Get Books",
                    Description = "Get books for school from DB",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId = 1
                },
                new Todo{
                    Id = 2,
                    Title = "Get Medicine",
                    Description = "Get Medicine for sickness",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(2),
                    Status = TodoStatus.InProgress,
                    AuthorId = 2
                },
                new Todo{
                    Id = 3,
                    Title = "Get Foods",
                    Description = "Get Foods from Resrurant",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(3),
                    Status = TodoStatus.InProgress,
                    AuthorId = 2
                }
        });
        }
    }
}
