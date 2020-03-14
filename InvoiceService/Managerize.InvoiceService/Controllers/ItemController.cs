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
        private readonly ItemsService _itemsService;

        public ItemController(ItemsService service) => _itemsService = service;

        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return _itemsService.ReadItems();
        }

        [HttpPost]
        public void Post(Item item)
        {
            _itemsService.AddItem(item);
        }
    }
}