using GrapgQI.EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrapgQI.EF.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Student>().HasData(
                                            new Student() { Name = "abc", Roll = "1", StudentID = 101 },
                                            new Student() { Name = "def", Roll = "2", StudentID = 102 },
                                            new Student() { Name = "ghi", Roll = "3", StudentID = 103 }
                                            );
        }
    }
}
