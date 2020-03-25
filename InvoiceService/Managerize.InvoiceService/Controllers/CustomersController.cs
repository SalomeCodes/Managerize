using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Managerize.InvoiceService.DAL;
using Managerize.InvoiceService.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Managerize.InvoiceService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomersService _customersService;
        public CustomersController(CustomersService service) => _customersService = service; 

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customersService.ReadCustomers();
        }
        
        [EnableCors("_myAllowSpecificOrigins")]
        [HttpPost]
        public void Post(Klant customer)
        {
            //return customer;
            //_customersService.AddCustomer(customer);
        }
    }

    public class Klant
    {
        public string Name { get; set; }
        public string Prefix { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string Place { get; set; }
        public string HouseNumber { get; set; }
    }
}