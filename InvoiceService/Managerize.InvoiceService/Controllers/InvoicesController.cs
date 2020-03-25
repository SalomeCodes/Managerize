using System;
using System.Collections.Generic;
using Managerize.InvoiceService.BLL;
using Managerize.InvoiceService.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [EnableCors("*")]
    public class InvoicesController : ControllerBase
    {
        private readonly IInvoiceLogic _managerizeInvoiceService;

        public InvoicesController(IInvoiceLogic service) => _managerizeInvoiceService = service;


        [HttpGet]
        public IEnumerable<Invoice> Get()
        {
            return _managerizeInvoiceService.ReadInvoices();
        }

        [HttpPost]
        public int Post(Invoice invoice)
        {
            return _managerizeInvoiceService.CreateInvoice(invoice);
        }

        [HttpGet]
        [Route("date")]
        public List<Invoice> GetInvoicesPerMonth(DateTime dateInput)
        {
            return _managerizeInvoiceService.ReadInvoicesPerMonth(dateInput);
        }

        [HttpGet]
        [Route("payment")]
        public IEnumerable<Invoice> GetInvoicesOnPayment([FromQuery(Name = "isPayed")] bool isPayed)
        {
            return _managerizeInvoiceService.ReadInvoicesOnPaymentStatus(isPayed);
        }
    }
}