import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { InvoiceLine } from 'src/app/models/InvoiceLine';

@Injectable()
export class InvoiceCreateService {

  private messageSource = new BehaviorSubject(new InvoiceLine());
  currentMessage = this.messageSource.asObservable();

  constructor() { }

  addInvoiceLine(item: InvoiceLine) {
    this.messageSource.next(item);
  }
}