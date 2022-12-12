using System;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementSystem.Data.Model;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Resident> Residents { get; set; }
    }
}

