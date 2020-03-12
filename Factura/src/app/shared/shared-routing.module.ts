import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { InvoicesOverviewComponent } from '../components/invoices/invoices-overview/invoices-overview.component';
import { InvoiceCreateComponent } from '../components/invoices/invoice-create/invoice-create.component';
import { CustomersOverviewComponent } from '../components/customers/customers-overview/customers-overview.component';
import { CustomerCreateComponent } from '../components/customers/customer-create/customer-create.component';
import { ItemsOverviewComponent } from '../components/items/items-overview/items-overview.component';
import { ItemCreateComponent } from '../components/items/item-create/item-create.component';
import { HomeComponent } from '../components/home/home.component';
import { HomeInvoiceComponent } from '../components/home/home-invoice/home-invoice.component';

const routes: Routes = [
  { path: '', component: HomeComponent},
  { path: 'home-facturen/facturen', component: InvoicesOverviewComponent },
  { path: 'home-facturen/facturen-toevoegen', component: InvoiceCreateComponent },
  { path: 'klanten', component: CustomersOverviewComponent },
  { path: 'klanten-toevoegen', component: CustomerCreateComponent },
  { path: 'producten', component: ItemsOverviewComponent },
  { path: 'producten-toevoegen', component: ItemCreateComponent },
  { path: 'home-facturen', component: HomeInvoiceComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SharedRoutingModule { }
