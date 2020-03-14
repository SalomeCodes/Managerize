using System;
using System.Collections.Generic;
using Managerize.InvoiceService.DAL;
using Managerize.InvoiceService.Models;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly InvoicesService _managerizeInvoiceService;

        public InvoiceController(InvoicesService service) => _managerizeInvoiceService = service;


        [HttpGet]
        public IEnumerable<Invoice> Get()
        {
            return _managerizeInvoiceService.ReadInvoices();
        }

        [HttpPost]
        public void Post(Invoice invoice)
        {
            _managerizeInvoiceService.AddInvoice(invoice);
        }
    }
}