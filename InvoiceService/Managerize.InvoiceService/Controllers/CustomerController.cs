﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Managerize.InvoiceService.DAL;
using Managerize.InvoiceService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Managerize.InvoiceService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomersService _customersService;
        public CustomerController(CustomersService service) => _customersService = service; 

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customersService.ReadCustomers();
        }
        
        [HttpPost]
        public void Post(Customer customer)
        {
            _customersService.AddCustomer(customer);
        }
    }
}