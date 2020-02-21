import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { InvoicesOverviewComponent } from './invoices-overview/invoices-overview.component';

const routes: Routes = [
  { path: 'facturen', component: InvoicesOverviewComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class InvoicesRoutingModule { }
