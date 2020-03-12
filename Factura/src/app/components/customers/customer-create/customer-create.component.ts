import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { CustomerService } from '../customer.service';
import { Router } from '@angular/router';

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

  onSubmit(){
    this.customerService.addCustomer(this.customerForm.value).subscribe(data => {
      if(data.name != ""){
        this.router.navigateByUrl("/klanten");
      }
    });
  }
}
