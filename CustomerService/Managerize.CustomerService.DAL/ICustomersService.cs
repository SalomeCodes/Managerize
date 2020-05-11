using Managerize.CustomerService.Models.Managerize.InvoiceService.Models;
using System.Collections.Generic;

namespace Managerize.CustomerService.DAL
{
    public interface ICustomersService
    {
        List<Customer> ReadCustomers();
        void AddCustomer(Customer customer);
    }
}
