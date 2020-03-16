using System;

namespace Managerize.InvoiceService.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public int CustomerNumber { get; set; }
        public string Name { get; set; }
        public string Prefix { get; set; }
        public string Surname { get; set; }
        public string ZipCode { get; set; }
        public string Place { get; set; }
        public string HouseNumber { get; set; }
        public string Street { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}