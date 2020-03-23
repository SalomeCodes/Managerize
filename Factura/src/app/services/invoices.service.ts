import { Injectable } from '@angular/core';
import { AppSettings } from '../app-settings';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Invoice } from '../models/Invoice';

const httpOptions = AppSettings.INVOICE_SERVICE_HEADER;

@Injectable({
  providedIn: 'root'
})
export class InvoicesService {

  private baseUrl: string = AppSettings.INVOICE_SERVICE_ENDPOINT;
  private invoicesUrl: string = '/invoices';
  private standarUrl: string = this.baseUrl + this.invoicesUrl;

  constructor(private httpClient: HttpClient) { }

  getInvoices(): Observable<Invoice[]> {
    return this.httpClient.get<Invoice[]>(this.standarUrl, httpOptions);
  }

  addPayment(invoice: Invoice): Observable<boolean> {
    return this.httpClient.put<boolean>(`${this.standarUrl}/${invoice.id}`, invoice, httpOptions);
  }

  saveInvoice(invoice: Invoice): Observable<number>{
    return this.httpClient.post<number>(this.standarUrl, invoice, httpOptions);
  }
  getInvoicesOnPayment(isPayed: boolean): Observable<Invoice[]> {
    let params = new HttpParams().set('isPayed', isPayed.toString());

    return this.httpClient.get<Invoice[]>(`${this.standarUrl}/payment`, { params: params });
  }
}
