import { Injectable } from '@angular/core';
import { AppSettings } from '../app-settings';
import { HttpClient, HttpParams, HttpRequest } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Invoice } from '../models/Invoice';
import { DatePipe } from '@angular/common';

const httpOptions = AppSettings.INVOICE_SERVICE_HEADER;

@Injectable({
  providedIn: 'root'
})
export class InvoicesService {

  private baseUrl: string = AppSettings.INVOICE_SERVICE_ENDPOINT;
  private invoicesUrl: string = '/invoices';
  private standarUrl: string = this.baseUrl + this.invoicesUrl;

  constructor(
    private httpClient: HttpClient,
    public datePipe: DatePipe
    ) { }

  getInvoices(date: Date): Observable<Invoice[]> {
    var datum = this.datePipe.transform(date, 'MM-dd-yyyy');
    let params = new HttpParams().set('dateInput', `${datum}`);
    return this.httpClient.get<Invoice[]>(`${this.standarUrl}/date`, { params: params });
  }

  addPayment(invoice: Invoice): Observable<boolean> {
    return this.httpClient.put<boolean>(`${this.standarUrl}/${invoice.id}`, invoice, httpOptions);
  }

  addIvoice(invoice: Invoice) {
    return this.httpClient.post<number>(`${this.baseUrl}/item`, invoice, httpOptions);
  }

  getInvoicesOnPayment(isPayed: boolean): Observable<Invoice[]> {
    let params = new HttpParams().set('isPayed', isPayed.toString());

    return this.httpClient.get<Invoice[]>(`${this.standarUrl}/payment`, { params: params });
  }
}
