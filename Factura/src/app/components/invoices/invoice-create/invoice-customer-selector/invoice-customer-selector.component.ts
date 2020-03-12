import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { Customer } from 'src/app/models/Customer';
import { CustomerService } from 'src/app/services/customer.service';

@Component({
  selector: 'app-invoice-customer-selector',
  templateUrl: './invoice-customer-selector.component.html',
  styleUrls: ['./invoice-customer-selector.component.scss']
})
export class InvoiceCustomerSelectorComponent implements OnInit {
  
  @Output() selectedCustomer = new EventEmitter<Customer>();

  customers: Customer[];
  customersPerPage: Customer[];
  displayedColumns: string[] = ['naam', 'adres', 'contact'];

  constructor(private customerService: CustomerService) { }

  ngOnInit() {
    this.customerService.getCustomers().subscribe(c => {
      this.customers = c;
      this.customersPerPage = c;
    });
  }

  selectCustomer(customer: any){
    this.selectedCustomer.emit(customer);
  }

  search(item) {
    if(item.length < 1){
      this.customersPerPage = this.customers;
    }
    else{
      this.customersPerPage = item;
    }
  }
}
