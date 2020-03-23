import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { Customer } from 'src/app/models/Customer';
import { CustomerService } from 'src/app/services/customer.service';
import { MatStepper } from '@angular/material/stepper';

@Component({
  selector: 'app-invoice-customer-selector',
  templateUrl: './invoice-customer-selector.component.html',
  styleUrls: [
    './invoice-customer-selector.component.scss',
    '../../../../shared/table.component.scss',
    '../../../../shared/button.component.scss'
  ]
})
export class InvoiceCustomerSelectorComponent implements OnInit {
  
  @Output() selectedCustomer = new EventEmitter<Customer>();
  @Output("goNext") goNext: EventEmitter<any> = new EventEmitter();

  customers: Customer[];
  customersPerPage: Customer[];

  constructor(private customerService: CustomerService) { }

  ngOnInit() {
    this.customerService.getCustomers().subscribe(c => {
      this.customers = c;
      this.customersPerPage = c.slice(0, 100);
    });
  }

  callParent(stepper: MatStepper){
    this.goNext.emit();
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
