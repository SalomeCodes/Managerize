using System.Collections.Generic;
using Managerize.CustomerService.DAL;
using Managerize.CustomerService.Models.Managerize.InvoiceService.Models;
using Microsoft.AspNetCore.Mvc;

namespace Managerize.CustomerService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersService _customersService;

        public CustomersController(ICustomersService customersService)
        {
            _customersService = customersService;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customersService.ReadCustomers();
        }

        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            _customersService.AddCustomer(customer);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer value)
        {

        }
    }
}
