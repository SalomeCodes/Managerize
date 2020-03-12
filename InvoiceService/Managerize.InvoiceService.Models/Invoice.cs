using System;
using System.Collections.Generic;

namespace Managerize.InvoiceService.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? DateSent { get; set; }
        public DateTime? DatePayed { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal PayedAmount { get; set; }
        public bool IsPayed { get; set; }

        public List<InvoiceLine> InvoiceLines { get; set; }
        public Customer Customer { get; set; }
    }
}
