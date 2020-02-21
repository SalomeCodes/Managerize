import { Component, OnInit, Input, OnChanges, SimpleChanges } from '@angular/core';
import { Customer } from 'src/app/models/Customer';
import { InvoiceLine } from 'src/app/models/InvoiceLine';
import { MatTableDataSource } from '@angular/material/table';
import { faEuroSign } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-invoice-checkup',
  templateUrl: './invoice-checkup.component.html',
  styleUrls: ['./invoice-checkup.component.scss']
})
export class InvoiceCheckupComponent {
  faEuroSign = faEuroSign;

  displayedColumns: string[] = ['description', 'amount', 'price', 'totalPrice'];
  @Input() selectedCustomer: Customer;
  @Input() invoiceLines = new MatTableDataSource<InvoiceLine>();
  date = new Date();

  constructor() { }

}
