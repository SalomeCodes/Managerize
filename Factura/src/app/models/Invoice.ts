import { Customer } from './Customer';
import { InvoiceLine } from './InvoiceLine';

export class Invoice{
    id: string;
    title: string;
    invoiceNumber: number;
    creationDate: Date;
    dateSent: Date;
    datePayed: Date;
    customer: Customer;
    invoiceLines: InvoiceLine[];
    totalPrice: number;
    payedAmount: number;
    isPayed: boolean;
}

// public Guid Id { get; set; }
// public int InvoiceNumber { get; set; }
// public DateTime CreationDate { get; set; }
// public DateTime? DateSent { get; set; }
// public DateTime? DatePayed { get; set; }
// public decimal TotalPrice { get; set; }
// public decimal PayedAmount { get; set; }
// public bool IsPayed { get; set; }

// public List<InvoiceLine> InvoiceLines { get; set; }
// public Customer Customer { get; set; }
// public List<Payment> PaymentHistory { get; set; }