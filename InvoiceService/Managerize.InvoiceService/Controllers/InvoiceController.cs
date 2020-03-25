using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Managerize.InvoiceService.BLL;
using Managerize.InvoiceService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Managerize.InvoiceService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceLogic _managerizeInvoiceService;

        public InvoiceController(IInvoiceLogic service) => _managerizeInvoiceService = service;

        [HttpPost]
        public void Post(Invoice invoice)
        {
            _managerizeInvoiceService.CreateInvoice(invoice);
        }
    }
}