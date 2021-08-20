using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<TodoModel> TodoModel { get; set; }

        //them 1 so du lieu da cho bang todoApp
        // add-migration seeddata => update-database seeddata(cap nhap vao sql)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoModel>().HasData(
                new TodoModel() { Id = 1, Name="Vanz", IsComplete = true, Description= "suitable for men and women" },
                new TodoModel() { Id = 2, Name = "Convert", IsComplete = false, Description = "suitable for men and women" },
                new TodoModel() { Id = 3, Name = "Nike", IsComplete = false, Description = "suitable for men and women" },
                new TodoModel() { Id = 4, Name = "Biti", IsComplete = true, Description = "suitable for men and women" }

             );
        }
    }
}
