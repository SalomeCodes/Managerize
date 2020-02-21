import { Injectable } from '@angular/core';
import { AppSettings } from '../app-settings';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Invoice } from '../models/Invoice';

const httpOptions = AppSettings.API_HEADER;

@Injectable({
  providedIn: 'root'
})
export class InvoicesService {

  private baseUrl:string = AppSettings.API_ENDPOINT;
  private invoicesUrl:string = '/invoices';
  private standarUrl: string = this.baseUrl + this.invoicesUrl;

  constructor(private httpClient: HttpClient) { }

  getInvoices():Observable<Invoice[]>{
   return this.httpClient.get<Invoice[]>(this.standarUrl, httpOptions);
  }

  addPayment(invoice: Invoice):Observable<boolean>{
    return this.httpClient.put<boolean>(`${this.standarUrl}/${invoice.id}`, invoice, httpOptions);
  }
}
