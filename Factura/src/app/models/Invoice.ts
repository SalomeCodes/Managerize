import { Customer } from './Customer';
import { InvoiceLine } from './InvoiceLine';

export class Invoice{
    id: number;
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