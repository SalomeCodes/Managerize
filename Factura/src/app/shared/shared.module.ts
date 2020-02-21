import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatButtonModule } from '@angular/material/button';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatMenuModule } from '@angular/material/menu';
import { MatExpansionModule } from '@angular/material/expansion';
import { MatTableModule } from '@angular/material/table';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatDialogModule } from '@angular/material/dialog';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatTooltipModule } from '@angular/material/tooltip';
import { MatStepperModule } from '@angular/material/stepper';

import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

import { NavigationComponent } from './navigation/navigation.component';
import { CustomersOverviewComponent } from '../customers/customers-overview/customers-overview.component';

import { SharedRoutingModule } from './shared-routing.module';
import { PaymentDialogComponent } from '../invoices/invoices-overview/payment-dialog/payment-dialog.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AutocompleterComponent } from './autocompleter/autocompleter/autocompleter.component';
import { CustomerCreateComponent } from '../customers/customer-create/customer-create.component';
import { ItemsOverviewComponent } from '../items/items-overview/items-overview.component';
import { ItemCreateComponent } from '../items/item-create/item-create.component';

@NgModule({
  declarations: [
    NavigationComponent,
    AutocompleterComponent,
    CustomersOverviewComponent,
    CustomerCreateComponent,
    ItemsOverviewComponent,
    ItemCreateComponent
  ],
  imports: [
    CommonModule,
    BrowserAnimationsModule,
    RouterModule,
    FormsModule,
    ReactiveFormsModule,

    MatButtonModule,
    MatToolbarModule,
    MatMenuModule,
    MatExpansionModule,
    MatTableModule,
    MatDialogModule,
    MatGridListModule,
    MatPaginatorModule,
    MatFormFieldModule,
    MatInputModule,
    MatCheckboxModule,
    MatTooltipModule,
    MatStepperModule,

    FontAwesomeModule,

    SharedRoutingModule,

  ],
  exports: [
    NavigationComponent,
    AutocompleterComponent
  ],
  entryComponents: [
    PaymentDialogComponent
  ]
})
export class SharedModule { }
