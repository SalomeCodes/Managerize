import { Injectable } from '@angular/core';
import { AppSettings } from '../app-settings';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Invoice } from '../models/Invoice';

const httpOptions = AppSettings.INVOICE_SERVICE_HEADER;

@Injectable({
  providedIn: 'root'
})
export class InvoicesService {

  private baseUrl: string = AppSettings.INVOICE_SERVICE_ENDPOINT;
  private invoicesUrl: string = '/invoice';
  private standarUrl: string = this.baseUrl + this.invoicesUrl;

  constructor(private httpClient: HttpClient) { }

  getInvoices(): Observable<Invoice[]> {
    return this.httpClient.get<Invoice[]>(this.standarUrl, httpOptions);
  }

  addPayment(invoice: Invoice): Observable<boolean> {
    return this.httpClient.put<boolean>(`${this.standarUrl}/${invoice.id}`, invoice, httpOptions);
  }

  saveInvoice(invoice: Invoice) {
    return this.httpClient.post<boolean>(this.standarUrl, invoice, httpOptions);
  }
}
