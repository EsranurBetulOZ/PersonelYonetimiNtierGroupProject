﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using NtierArchitecture.Entities.Models;
using System.Configuration;

namespace NtierArchitecture.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        

       
        public DbSet<Department> Departments { get; set; }
        public DbSet<Discontinuity> Discontinuities { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Leave> Leaves { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("database.json", optional: false, reloadOnChange: true)
              .Build();


          
            string connectionString = configuration.GetConnectionString("EnderSql");


            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
