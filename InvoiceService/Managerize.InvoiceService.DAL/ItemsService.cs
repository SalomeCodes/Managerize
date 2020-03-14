using Managerize.InvoiceService.Models;
using System.Collections.Generic;
using System.Linq;

namespace Managerize.InvoiceService.DAL
{
    public class ItemsService
    {
        private readonly InvoiceContext _invoiceContext;

        public ItemsService(InvoiceContext context) => _invoiceContext = context;

        public List<Item> ReadItems()
        {
            return _invoiceContext.Items.ToList();
        }

        public void AddItem(Item item)
        {
            _invoiceContext.Add(item);
            _invoiceContext.SaveChanges();
        }
    }
}
