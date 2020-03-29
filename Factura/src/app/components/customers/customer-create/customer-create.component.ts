import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Router } from '@angular/router';
import { CustomerService } from 'src/app/services/customer.service';

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
    zipCode: new FormControl(''),
    place: new FormControl(''),
    houseNumber: new FormControl(''),
    phone: new FormControl(''),
    email: new FormControl('')
  });

  constructor(
    private customerService: CustomerService,
    private router: Router
  ) { }

  ngOnInit() {
  }

  onSubmit() {
    this.customerService.addCustomer(this.customerForm.value).subscribe(data => {
      this.router.navigateByUrl("/customers");
    });
  }
}
