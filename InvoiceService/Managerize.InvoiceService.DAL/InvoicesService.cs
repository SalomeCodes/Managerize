using Managerize.InvoiceService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Managerize.InvoiceService.DAL
{
    public class InvoicesService
    {
        private readonly InvoiceContext _invoiceContext;

        public InvoicesService(InvoiceContext context) => _invoiceContext = context;

        public List<Invoice> ReadInvoices()
        {
            return _invoiceContext.Invoices.Include(invoice => invoice.Customer).ToList();
        }
        public void AddInvoice(Invoice invoice)
        {
            _invoiceContext.Add(invoice);
            _invoiceContext.SaveChanges();
        }
    }
}
