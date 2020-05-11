using Managerize.InvoiceService.DAL;
using Managerize.InvoiceService.Models;
using System;
using System.Collections.Generic;

namespace Managerize.InvoiceService.BLL
{
    public class InvoiceLogic : IInvoiceLogic
    {
        private readonly InvoicesService _invoicesService;
        public InvoiceLogic(InvoicesService invoicesService) => _invoicesService = invoicesService;

        public int CreateInvoice(Invoice invoice)
        {
            invoice.InvoiceLines.ForEach(line => {
                invoice.TotalPrice += Decimal.Round((line.Amount * line.Item.Price), 2);
            });
            return _invoicesService.CreateInvoice(invoice);
        }

        public List<Invoice> ReadInvoices()
        {
            return _invoicesService.ReadInvoices();
        }
        public List<Invoice> ReadInvoicesPerMonth(DateTime dateTime)
        {
            return _invoicesService.ReadInvoicesPerMonthSent(dateTime);
        }

        public List<Invoice> ReadInvoicesOnPaymentStatus(bool isPayed)
        {
            return _invoicesService.ReadInvoicesOnPaymentStatus(isPayed);
        }

        public void AddPayment(Invoice invoice)
        {
            _invoicesService.AddPayment(invoice);
        }
    }
}
