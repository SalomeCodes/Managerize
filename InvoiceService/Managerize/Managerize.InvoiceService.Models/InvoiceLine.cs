namespace Managerize.InvoiceService.Models
{
    public class InvoiceLine
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public int Amount { get; set; }
    }
}