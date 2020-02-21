import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { InvoicesOverviewComponent } from '../invoices/invoices-overview/invoices-overview.component';
import { CustomersOverviewComponent } from '../customers/customers-overview/customers-overview.component';
import { InvoiceCreateComponent } from '../invoices/invoice-create/invoice-create.component';
import { CustomerCreateComponent } from '../customers/customer-create/customer-create.component';
import { ItemsOverviewComponent } from '../items/items-overview/items-overview.component';
import { ItemCreateComponent } from '../items/item-create/item-create.component';

const routes: Routes = [
  { path: 'facturen', component: InvoicesOverviewComponent },
  { path: 'facturen-toevoegen', component: InvoiceCreateComponent },
  { path: 'klanten', component: CustomersOverviewComponent },
  { path: 'klanten-toevoegen', component: CustomerCreateComponent },
  { path: 'producten', component: ItemsOverviewComponent },
  { path: 'producten-toevoegen', component: ItemCreateComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SharedRoutingModule { }
