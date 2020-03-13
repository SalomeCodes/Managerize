import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HomeService {

  constructor() { }

  getHomeModules() {
    return [
      { module: 'invoices', title: 'Facturen', iconDefinition: 'fa fa-file-pdf-o', routerLink: '' },
      { module: 'customers', title: 'Klanten', iconDefinition: 'fa fa-users', routerLink: '' },
      { module: 'items', title: 'Producten', iconDefinition: 'fa fa-shopping-cart', routerLink: '' }
    ]
  }

  getSpecificModule(module: string) {
    return [
      { module: 'invoices', title: 'Facturen overzicht', iconDefinition: 'fa fa-list', routerLink: 'invoices'},
      { module: 'invoices', title: 'Nieuw factuur', iconDefinition: 'fa fa-plus', routerLink: 'invoices/create' },
      { module: 'customers', title: 'Klanten overzicht', iconDefinition: 'fa fa-list', routerLink: 'customers' },
      { module: 'customers', title: 'Nieuwe klant', iconDefinition: 'fa fa-plus', routerLink: 'customers/create' },
      { module: 'items', title: 'Producten overzicht', iconDefinition: 'fa fa-list', routerLink: 'items' },
      { module: 'items', title: 'Nieuw product', iconDefinition: 'fa fa-plus', routerLink: 'items/create' }
    ].filter(m => m.module == module);
  }
}
