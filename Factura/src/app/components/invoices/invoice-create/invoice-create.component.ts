import { Component, OnInit } from '@angular/core';
import {
  FormGroup,
  FormBuilder,
  Validators
} from '@angular/forms';
import { Customer } from 'src/app/models/Customer';
import { InvoiceLine } from 'src/app/models/InvoiceLine';
import { MatStepper } from '@angular/material/stepper';
import { Invoice } from 'src/app/models/Invoice';
import { InvoicesService } from 'src/app/services/invoices.service';
import { Router } from '@angular/router';


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
    private invoiceService: InvoicesService,
    private router: Router
  ) { }

  ngOnInit() {
    this.firstFormGroup = this._formBuilder.group({
      firstCtrl: ['', Validators.required]
    });
    this.secondFormGroup = this._formBuilder.group({
      secondCtrl: ['', Validators.required]
    });
  }

  goNext(stepper: MatStepper) {
    stepper.next();
  }

  selectCustomer($event) {
    this.selectedCustomer = $event;
  }

  addItem($event) {
    const index = this.invoiceLines.findIndex((e) => e.item.id === $event.item.id);

    if (index === -1) {
      this.invoiceLines.push($event);
    } else {
      this.invoiceLines[index].amount = +this.invoiceLines[index].amount + +$event.amount;
    }
    this.invoiceLines = [].concat(this.invoiceLines); //triggers onchange detection
  }

  createInvoice() {
    var invoice = new Invoice();
    invoice.creationDate = new Date();
    invoice.customer = this.selectedCustomer;
    invoice.dateSent = new Date();
    invoice.invoiceLines = this.invoiceLines;
    this.invoiceService.saveInvoice(invoice).subscribe(resp => 
        this.router.navigateByUrl("/invoices")
      );
  }
}
