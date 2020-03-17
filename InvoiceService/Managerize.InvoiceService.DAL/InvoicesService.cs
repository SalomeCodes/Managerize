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
            return _invoiceContext.Invoices
                .Include(invoice => invoice.Customer)
                .Include("InvoiceLines.Item")
                .ToList();
        }
        public void AddInvoice(Invoice invoice)
        {
            _invoiceContext.Customers.Attach(invoice.Customer);
            invoice.InvoiceLines.ForEach(line =>
                _invoiceContext.Items.Attach(line.Item));

            _invoiceContext.Add(invoice);
            _invoiceContext.SaveChanges();
        }
    }
}
