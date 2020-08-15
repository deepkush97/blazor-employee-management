using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Department Tab
            modelBuilder.Entity<Department>()
                .HasData( new Department { DepartmentId = 1, DepartmentName = "Software" });
            modelBuilder.Entity<Department>()
                .HasData( new Department { DepartmentId = 2, DepartmentName = "Automation" });
            modelBuilder.Entity<Department>()
                .HasData( new Department { DepartmentId = 3, DepartmentName = "HR" });
            modelBuilder.Entity<Department>()
                .HasData( new Department { DepartmentId = 4, DepartmentName = "Finance" });

            modelBuilder.Entity<Employee>()
                .HasData(new Employee
                {
                    EmployeeId = 1,
                    FirstName = "Deep",
                    LastName = "Kush",
                    Email = "deep@kush.com",
                    DateOfBirth = new DateTime(year: 1997, month: 04, day: 08),
                    Gender = Gender.Male,
                    DepartmentId = 1,
                    PhotoPath = "images/pic03.jpg"
                });
            modelBuilder.Entity<Employee>()
                .HasData(new Employee
                {
                    EmployeeId = 2,
                    FirstName = "Deep2",
                    LastName = "Kush2",
                    Email = "deep2@kush2.com",
                    DateOfBirth = new DateTime(year: 1997, month: 05, day: 09),
                    Gender = Gender.Female,
                    DepartmentId = 2,
                    PhotoPath = "images/pic04.jpg"
                });
            modelBuilder.Entity<Employee>()
                .HasData(new Employee
                {
                    EmployeeId = 3,
                    FirstName = "Deep3",
                    LastName = "Kush3",
                    Email = "deep3@kush3.com",
                    DateOfBirth = new DateTime(year: 1997, month: 06, day: 09),
                    Gender = Gender.Male,
                    DepartmentId = 3,
                    PhotoPath = "images/pic05.jpg"
                });
            modelBuilder.Entity<Employee>()
                .HasData(new Employee
                {
                    EmployeeId = 4,
                    FirstName = "Deep4",
                    LastName = "Kush4",
                    Email = "deep4@kush4.com",
                    DateOfBirth = new DateTime(year: 1997, month: 07, day: 10),
                    Gender = Gender.Male,
                    DepartmentId = 4,
                    PhotoPath = "images/pic06.jpg"
                });
        }


    }
}
