import { Injectable } from '@angular/core';
import { AppSettings } from '../app-settings';
import { Observable } from 'rxjs';
import { Customer } from '../models/Customer';
import { HttpClient } from '@angular/common/http';

const httpOptions = AppSettings.INVOICE_SERVICE_HEADER;

@Injectable({
  providedIn: 'root'
})
export class CustomerService {
  private baseUrl:string = AppSettings.INVOICE_SERVICE_ENDPOINT;
  private invoicesUrl:string = '/customers';
  private standarUrl: string = this.baseUrl + this.invoicesUrl;

  constructor(private httpClient: HttpClient) { }

  getCustomers():Observable<Customer[]>{
    return this.httpClient.get<Customer[]>(this.standarUrl, httpOptions);
  }
  addCustomer(customer: Customer){
    console.log(customer);
    return this.httpClient.post<Customer>(this.standarUrl, customer, httpOptions);
  }
}
