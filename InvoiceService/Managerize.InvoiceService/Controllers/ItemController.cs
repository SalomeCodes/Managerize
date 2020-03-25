using System;
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
    public class ItemController : ControllerBase
    {
        private readonly InvoicesService _itemsService;

        public ItemController(InvoicesService service) => _itemsService = service;

        [HttpGet]
        public IEnumerable<Invoice> Get()
        {
            return _itemsService.ReadInvoices();
        }

        [HttpPost]
        public void Post(Invoice item)
        {
            _itemsService.CreateInvoice(item);
        }
    }
}