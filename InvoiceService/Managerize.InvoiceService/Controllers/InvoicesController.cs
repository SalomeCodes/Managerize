using System;
using System.Collections.Generic;
using Managerize.InvoiceService.DAL;
using Managerize.InvoiceService.Models;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private readonly InvoicesService _managerizeInvoiceService;

        public InvoicesController(InvoicesService service) => _managerizeInvoiceService = service;


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

        [HttpGet]
        [Route("payment")]
        public IEnumerable<Invoice> GetInvoicesOnPayment([FromQuery(Name = "isPayed")] bool isPayed)
        {
            return _managerizeInvoiceService.ReadInvoicesOnPaymentStatus(isPayed);
        }

    }
}