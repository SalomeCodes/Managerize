import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { InvoicesOverviewComponent } from './invoices-overview/invoices-overview.component';
import { RouterModule } from '@angular/router';
import { PaymentDialogComponent } from './invoices-overview/payment-dialog/payment-dialog.component';
import { InvoiceCreateComponent } from './invoice-create/invoice-create.component';
import { InvoiceCustomerSelectorComponent } from './invoice-create/invoice-customer-selector/invoice-customer-selector.component';

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
import { MatRadioModule } from '@angular/material/radio';
import { MatTooltipModule } from '@angular/material/tooltip';
import { MatStepperModule } from '@angular/material/stepper';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { InvoiceItemsSelectorComponent } from './invoice-create/invoice-items-selector/invoice-items-selector.component';
import { ItemAddedComponent } from './invoice-create/invoice-items-selector/invoice-added-item-snackbar/invoice-added-item';
import { InvoiceCheckupComponent } from './invoice-create/invoice-checkup/invoice-checkup.component';
import { InvoiceCreateService } from './invoice-create/invoice-create.service';
import { SharedModule } from 'src/app/shared/shared.module';
import { SearchInvoiceComponent } from './invoices-overview/search-invoice/search-invoice.component';
import { MatNativeDateModule } from '@angular/material/core';
import { ItemsService } from 'src/app/services/items.service';
import { CustomerService } from 'src/app/services/customer.service';
import { InvoicesService } from 'src/app/services/invoices.service';

@NgModule({
  declarations: [
    InvoicesOverviewComponent,
    PaymentDialogComponent,
    InvoiceCreateComponent,
    InvoicesOverviewComponent,
    InvoiceCustomerSelectorComponent,
    InvoiceItemsSelectorComponent,
    ItemAddedComponent,
    InvoiceCheckupComponent,
    SearchInvoiceComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    RouterModule,
    FormsModule,
    ReactiveFormsModule,
    
    MatRadioModule, 
    MatGridListModule,
    MatButtonModule,
    MatToolbarModule,
    MatMenuModule,
    MatExpansionModule,
    MatTableModule,
    MatDialogModule,
    MatGridListModule,
    MatPaginatorModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatFormFieldModule,
    MatInputModule,
    MatCheckboxModule,
    MatTooltipModule,
    MatStepperModule,
    MatSnackBarModule
  ],
  entryComponents: [
    PaymentDialogComponent, 
    ItemAddedComponent
  ],
  providers: [
    InvoiceCreateService,
    InvoicesService,
    ItemsService,
    CustomerService
  ]
})
export class InvoicesModule { }
