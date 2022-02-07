using System;
using Microsoft.EntityFrameworkCore;

namespace Mission6.Models
{
    public class TaskDataContext : DbContext
    {
        //Constructor
        public TaskDataContext(DbContextOptions<TaskDataContext> options) : base(options)
        {
            //Blank for now
        }

        public DbSet<Tasks> Tasks { get; set; }

        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                    new Category
                    {
                        CategoryID = 1,
                        CategoryName = "Home"
                    },
                    new Category
                    {
                        CategoryID = 2,
                        CategoryName = "School"
                    },
                    new Category
                    {
                        CategoryID = 3,
                        CategoryName = "Work"
                    },
                    new Category
                    {
                        CategoryID = 4,
                        CategoryName = "Church"
                    }
                    
                );

            mb.Entity<Tasks>().HasData(

                    new Tasks
                    {
                        TaskID = 1,
                        Task = "Due 404 HW",
                        DueDate = new DateTime(2022, 10, 10, 1, 1, 1),
                        Quadrant = 1,
                        CategoryID = 2,
                        Completed = true
                    },
                    new Tasks
                    {
                        TaskID = 2,
                        Task = "Finish Mission 6",
                        DueDate = new DateTime(2022, 10, 10, 1, 1, 1),
                        Quadrant = 3,
                        CategoryID = 2,
                        Completed = true
                    },
                    new Tasks
                    {
                        TaskID = 3,
                        Task = "Fulfill Church Calling",
                        DueDate = new DateTime(2022, 10, 10, 1, 1, 1),
                        Quadrant = 4,
                        CategoryID = 4,
                        Completed = false
                    }
                );
        }
    }
}
