using HospitalDB.Configuration;
using HospitalDB.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class SweetShopDbContext: DbContext
    {
        public SweetShopDbContext(DbContextOptions options) : base(options)
        {

        }

        public SweetShopDbContext()
        {

        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Employee> Employeess { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Confectionary> Confectionaries { get; set; }
        public DbSet<Confectionary_Order> confectionary_Orders { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Configuration can be found in configuration folder 
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());
            modelBuilder.ApplyConfiguration(new Confectionary_OrderConfig());
            modelBuilder.ApplyConfiguration(new ConfectionaryConfig());

            //Seed Data
            modelBuilder.Seed();
        }
    }
}
