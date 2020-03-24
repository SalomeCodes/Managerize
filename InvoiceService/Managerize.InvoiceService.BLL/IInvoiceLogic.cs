using Managerize.InvoiceService.Models;
using System;
using System.Collections.Generic;

namespace Managerize.InvoiceService.BLL
{
    public interface IInvoiceLogic
    {
        public int CreateInvoice(Invoice invoice);
        public List<Invoice> ReadInvoices();
        public List<Invoice> ReadInvoicesPerMonth(DateTime dateTime);
        public List<Invoice> ReadInvoicesOnPaymentStatus(bool isPayed);
    }
}
