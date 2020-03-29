import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { InvoiceCreateComponent } from './components/invoices/invoice-create/invoice-create.component';
import { InvoicesOverviewComponent } from './components/invoices/invoices-overview/invoices-overview.component';
import { CustomerCreateComponent } from './components/customers/customer-create/customer-create.component';
import { CustomersOverviewComponent } from './components/customers/customers-overview/customers-overview.component';
import { ItemCreateComponent } from './components/items/item-create/item-create.component';
import { ItemsOverviewComponent } from './components/items/items-overview/items-overview.component';
import { HomeComponent } from './components/home/home.component';
import { ContentLayoutComponent } from './layout/content-layout/content-layout.component';
import { TestComponent } from './components/customers/test/test.component';

const routes: Routes = [
  { 
    path: '', 
    component: ContentLayoutComponent,
    children: [
      { path: '', component: HomeComponent },
      { path: 'invoices', component: InvoicesOverviewComponent },
      { path: 'invoices/create', component: InvoiceCreateComponent },
      { path: 'customers', component: CustomersOverviewComponent },
      { path: 'customers/create', component: CustomerCreateComponent },
      { path: 'items', component: ItemsOverviewComponent },
      { path: 'items/create', component: ItemCreateComponent },
      { path: 'test', component: TestComponent }
    ]
  },
  { path: 'test', component: TestComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
