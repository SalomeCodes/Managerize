import { Component, OnInit } from '@angular/core';
import { Customer } from 'src/app/models/Customer';
import { faFilter, faSearch } from '@fortawesome/free-solid-svg-icons';
import { CustomerService } from 'src/app/services/customer.service';

@Component({
  selector: 'app-customers-overview',
  templateUrl: './customers-overview.component.html',
  styleUrls: [
    './customers-overview.component.scss', 
    '../../../shared/table.component.scss']
})
export class CustomersOverviewComponent implements OnInit {

  faFilter = faFilter;
  faSearch = faSearch;

  customers: Customer[] = [];
  customersPerPage: Customer[] = [];
  displayedColumns: string[] = ['naam', 'adres', 'contact'];
  
  constructor(
    private customerService: CustomerService
  ) { }

  ngOnInit() {
    this.customerService.getCustomers().subscribe(customers => {
      this.customers = customers;
      this.customersPerPage = customers;
    })
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
