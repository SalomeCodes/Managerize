import { Component, Input, OnChanges, SimpleChanges, Output, EventEmitter } from '@angular/core';
import { Customer } from 'src/app/models/Customer';
import { InvoiceLine } from 'src/app/models/InvoiceLine';
import { InvoiceCreateService } from '../invoice-create.service';
import { Invoice } from 'src/app/models/Invoice';

@Component({
  selector: 'app-invoice-checkup',
  templateUrl: './invoice-checkup.component.html',
  styleUrls: ['./invoice-checkup.component.scss']
})
export class InvoiceCheckupComponent implements OnChanges{
  priceAdded: boolean = false;

  @Output() invoiceCreated = new EventEmitter<Invoice>();

  ngOnChanges() {
    this.invoiceService.currentMessage.subscribe( item => 
      {
        if(item.item != null && !this.priceAdded)
        {
          this.priceAdded = true;
          this.subTotalPrice += (item.amount * item.item.price);
          this.btwPrice = (this.subTotalPrice * 0.21);
          this.totalPrice = this.btwPrice + this.subTotalPrice;
        }
      })
      this.priceAdded = false;
      this.invoiceCreated.emit(this.createInvoice());
  }

  createInvoice() : Invoice{
    var invoice = new Invoice();
    invoice.creationDate = new Date();
    invoice.customer = this.selectedCustomer;
    invoice.dateSent = new Date();
    invoice.invoiceLines = this.invoiceLines;

      return invoice;
  }

  displayedColumns: string[] = ['description', 'amount', 'price', 'totalPrice'];
  @Input() selectedCustomer: Customer;
  @Input() invoiceLines: InvoiceLine[];
  date = new Date();
  subTotalPrice: number = 0; 
  btwPrice: number = 0; 
  totalPrice: number = 0; 

  constructor(
    private invoiceService: InvoiceCreateService
  ) { 
    this.subTotalPrice = 0;
  }

  removeItemFromInvoice(invoiceLine: InvoiceLine){
    this.invoiceLines.splice(this.invoiceLines.indexOf(invoiceLine), 1)
  }
}
