using Managerize.CustomerService.Models.Managerize.InvoiceService.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Managerize.CustomerService.DAL
{
    public class CustomersContext : DbContext
    {
        public CustomersContext(DbContextOptions<CustomersContext> options)
            : base(options)
        {
            Console.WriteLine(Environment.GetEnvironmentVariable("MANAGERIZE_CUSTOMER_SERVICE_DB"));
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(c =>
            {
                c.HasIndex(n => n.CustomerNumber).IsUnique();
            });
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
