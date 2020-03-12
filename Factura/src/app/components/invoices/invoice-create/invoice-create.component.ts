import { Component, OnInit } from '@angular/core';
import {  FormGroup,
          FormBuilder,
          Validators } from '@angular/forms';
import { Customer } from 'src/app/models/Customer';
import { InvoiceLine } from 'src/app/models/InvoiceLine';
import { InvoiceCreateService } from './invoice-create.service';

@Component({
  selector: 'app-invoice-create',
  templateUrl: './invoice-create.component.html',
  styleUrls: ['./invoice-create.component.scss']
})
export class InvoiceCreateComponent implements OnInit {

  isLinear = false;
  firstFormGroup: FormGroup;
  secondFormGroup: FormGroup;
  selectedCustomer: Customer;
  invoiceLines: InvoiceLine[] = [];

  constructor(
      private _formBuilder: FormBuilder,
      private invoiceService: InvoiceCreateService
    ) {}

  ngOnInit() {
    this.firstFormGroup = this._formBuilder.group({
      firstCtrl: ['', Validators.required]
    });
    this.secondFormGroup = this._formBuilder.group({
      secondCtrl: ['', Validators.required]
    });
  }

  selectCustomer($event){
    this.selectedCustomer = $event;
  }

  addItem($event){
    this.invoiceLines.push($event);
    this.invoiceLines = [].concat(this.invoiceLines); //triggers onchange detection
  }

}
