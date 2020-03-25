import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Router } from '@angular/router';
import { CustomerService } from 'src/app/services/customer.service';
import { Customer } from 'src/app/models/Customer';

@Component({
  selector: 'app-customer-create',
  templateUrl: './customer-create.component.html',
  styleUrls: ['./customer-create.component.scss']
})
export class CustomerCreateComponent implements OnInit {
  customerForm = new FormGroup({
    name: new FormControl(''),
    prefix: new FormControl(''),
    surname: new FormControl(''),
    street: new FormControl(''),
    zipcode: new FormControl(''),
    place: new FormControl(''),
    housenumber: new FormControl('')
  });

  constructor(
    private customerService: CustomerService,
    private router: Router
  ) { }

  ngOnInit() {
  }

  onSubmit() {
    var customer = new Customer();
    customer.customerNumber = null;
    customer.name = this.customerForm.value.name;
    customer.prefix = this.customerForm.value.prefix;
    customer.surname = this.customerForm.value.surname;
    customer.street = this.customerForm.value.street;
    customer.houseNumber = this.customerForm.value.houseNumber;
    customer.zipCode = this.customerForm.value.zipCode;
    customer.place = this.customerForm.value.place;
    customer.email = "";
    customer.phoneNumber = "";

    this.customerService.addCustomer(customer).subscribe(data => {
      this.router.navigateByUrl("/customers");
    });
  }
}
