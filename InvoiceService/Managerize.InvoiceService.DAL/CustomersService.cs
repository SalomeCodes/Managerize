using Managerize.InvoiceService.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Managerize.InvoiceService.DAL
{
    public class CustomersService
    {
        private readonly InvoiceContext _invoiceContext;

        public CustomersService(InvoiceContext context) => _invoiceContext = context;

        public List<Customer> ReadCustomers()
        {
            return _invoiceContext.Customers.ToList();
        }
        public void AddCustomer(Customer customer)
        {
            _invoiceContext.Add(customer);
            _invoiceContext.SaveChanges();
        }
    }
}
