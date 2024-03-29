﻿using System;
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
        
        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            try
            {
                _customersService.AddCustomer(customer);
                return Ok();
            }
            catch(Exception ex)
            {
                return StatusCode(1, ex);
            }
        }
    }
}