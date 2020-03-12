using System;

namespace Managerize.InvoiceService.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

    }
}