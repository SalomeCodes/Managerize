using Managerize.CustomerService.Models.Managerize.InvoiceService.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Managerize.CustomerService.DAL
{
    public class CustomersService : ICustomersService
    {
        private readonly CustomersContext _customerContext;

        public CustomersService(CustomersContext context)
        {
            _customerContext = context;
        }

        public List<Customer> ReadCustomers()
        {
            return _customerContext.Customers.ToList();
        }
        public void AddCustomer(Customer customer)
        {
            customer.Id = new Guid();
            _customerContext.Add(customer);
            _customerContext.SaveChanges();
        }
    }
}
