import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CustomersRoutingModule } from './customers-routing.module';
import { CustomersOverviewComponent } from './customers-overview/customers-overview.component';
import { CustomerCreateComponent } from './customer-create/customer-create.component';


@NgModule({
  declarations: [CustomersOverviewComponent, CustomerCreateComponent],
  imports: [
    CommonModule,
    CustomersRoutingModule
  ],
  exports: [
    CustomersOverviewComponent
  ]
})
export class CustomersModule { }
