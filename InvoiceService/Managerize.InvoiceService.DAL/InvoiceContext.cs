using Managerize.InvoiceService.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Managerize.InvoiceService.DAL
{
    public class InvoiceContext : DbContext 
    {
        public InvoiceContext(DbContextOptions<InvoiceContext> options)
            :base(options) {
            Console.WriteLine(Environment.GetEnvironmentVariable("MANAGERIZE_INVOICE_SERVICE_DB"));
            Database.EnsureCreated();
        }

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<InvoiceLine> InvoiceLines { get; set; }
    }
}
