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

        public List<Invoice> ReadInvoicesPerMonthSent(DateTime creationDate)
        {
            return _invoiceContext.Invoices.Where(i => i.CreationDate.Month == creationDate.Month && i.CreationDate.Year == creationDate.Year)
                .Include(invoice => invoice.Customer)
                .Include("InvoiceLines.Item")
                .ToList();
        }

        public List<Invoice> ReadInvoicesPerMonthSent(DateTime dateSent, bool isPayed)
        {
            return _invoiceContext.Invoices.Where(i => i.DateSent == dateSent && i.IsPayed == isPayed)
                .Include(invoice => invoice.Customer)
                .Include("InvoiceLines.Item")
                .ToList();
        }

        public List<Invoice> ReadInvoicesOnPaymentStatus(bool isPayed)
        {
            return _invoiceContext.Invoices.Where(i => i.IsPayed == isPayed)
                .Include(invoice => invoice.Customer)
                .Include("InvoiceLines.Item")
                .OrderBy(i => i.CreationDate)
                .ToList();
        }

        public void AddPayment(Invoice invoice)
        {
            var inv = _invoiceContext.Invoices.Find(invoice);
            inv.PayedAmount = invoice.PayedAmount;
            _invoiceContext.Update(inv);
            _invoiceContext.SaveChanges();
        }

        public int CreateInvoice(Invoice invoice)
        {
            _invoiceContext.Customers.Attach(invoice.Customer);
            invoice.InvoiceLines.ForEach(line =>
                _invoiceContext.Items.Attach(line.Item));

            _invoiceContext.Add(invoice);
            _invoiceContext.SaveChanges();
            return invoice.InvoiceNumber;
        }
    }
}
