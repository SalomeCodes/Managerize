import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AppSettings } from '../app-settings';
import { Item } from '../models/Item';
import { Observable } from 'rxjs';

const httpOptions = AppSettings.INVOICE_SERVICE_HEADER;

@Injectable({
  providedIn: 'root'
})
export class ItemsService {

  private baseUrl:string = AppSettings.INVOICE_SERVICE_ENDPOINT;
  private invoicesUrl:string = '/items';
  private standarUrl: string = this.baseUrl + this.invoicesUrl;

  constructor( private httpClient: HttpClient ) { }

  getItems():Observable<Item[]>{
    return this.httpClient.get<Item[]>(this.standarUrl, httpOptions);
  }
  addItem(item: Item){
    return this.httpClient.post<Item>(this.standarUrl, item, httpOptions);
  }
}