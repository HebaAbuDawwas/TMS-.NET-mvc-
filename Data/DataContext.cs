using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TMS.Models;

namespace TMS.Data
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> tblEmployees { get; set; }

        public DbSet<Project> tblProjects { get; set; }

        public DbSet<EmployeeProject> tblEmployeesProjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new Project { ProjectId = 1, Name = "Project 1", Size = eSize.Big, Icon= Array.Empty<byte>()},
                new Project { ProjectId = 2, Name = "Project 2", Size = eSize.Normal, Icon = Array.Empty<byte>() },
                new Project { ProjectId = 3, Name = "Project 3", Size = eSize.Small, Icon = Array.Empty<byte>() }
                );
            modelBuilder.Entity<Employee>().HasData(
                  new Employee { EmployeeId = 1, Name = "Employee 1", FeesPerDay = 15 , Photo="/Images/userprofile.png"},
                  new Employee { EmployeeId = 2, Name = "Employee 2", FeesPerDay = 25 , Photo= "/Images/employee2.jpg" },
                  new Employee { EmployeeId = 3, Name = "Employee 3", FeesPerDay = 10 , Photo = "/Images/userprofile.png" }
                );
            modelBuilder.Entity<EmployeeProject>().HasData(
                new EmployeeProject
                {
                    EmployeeProjectId = 1,
                    EmployeeId = 1,
                    ProjectId = 1,
                    StartDate = DateTime.Now.AddDays(-7),
                    EndDate = DateTime.Now.AddDays(-2),
                    Status = eStatus.Done
                },
                 new EmployeeProject
                 {
                     EmployeeProjectId = 2,
                     EmployeeId = 2,
                     ProjectId = 2,
                     StartDate = DateTime.Now.AddDays(-5),
                     EndDate = DateTime.Now.AddDays(+2),
                     Status = eStatus.InProgress
                 },
                 new EmployeeProject
                 {
                     EmployeeProjectId = 3,
                     EmployeeId = 3,
                     ProjectId = 3,
                     StartDate = DateTime.Now.AddDays(+2),
                     EndDate = DateTime.Now.AddDays(+7),
                     Status = eStatus.New
                 },
                  new EmployeeProject
                  {
                      EmployeeProjectId = 4,
                      EmployeeId = 2,
                      ProjectId = 1,
                      StartDate = DateTime.Now.AddDays(-10),
                      EndDate = DateTime.Now.AddDays(-2),
                      Status = eStatus.InProgress
                  },
                   new EmployeeProject
                   {
                       EmployeeProjectId = 5,
                       EmployeeId = 1,
                       ProjectId = 3,
                       StartDate = DateTime.Now.AddDays(-4),
                       EndDate = DateTime.Now.AddDays(+1),
                       Status = eStatus.Done
                   }
                );
        }

    }
}
