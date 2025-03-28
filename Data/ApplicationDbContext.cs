﻿using AdminPortal.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminPortal.Data
{
    public class ApplicationDbContext : DbContext
    {

        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        //{
            
        //} 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
