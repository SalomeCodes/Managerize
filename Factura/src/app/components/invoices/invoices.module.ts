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
import { MatTooltipModule } from '@angular/material/tooltip';
import { MatStepperModule } from '@angular/material/stepper';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { InvoiceItemsSelectorComponent } from './invoice-create/invoice-items-selector/invoice-items-selector.component';
import { ItemAddedComponent } from './invoice-create/invoice-items-selector/invoice-added-item-snackbar/invoice-added-item';
import { InvoiceCheckupComponent } from './invoice-create/invoice-checkup/invoice-checkup.component';
import { InvoiceCreateService } from './invoice-create/invoice-create.service';
import { SharedModule } from 'src/app/shared/shared.module';

@NgModule({
  declarations: [
    InvoicesOverviewComponent,
    PaymentDialogComponent,
    InvoiceCreateComponent,
    InvoicesOverviewComponent,
    InvoiceCustomerSelectorComponent,
    InvoiceItemsSelectorComponent,
    ItemAddedComponent,
    InvoiceCheckupComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    RouterModule,
    FormsModule,
    ReactiveFormsModule,
    
    MatGridListModule,
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
    MatSnackBarModule,
    FontAwesomeModule
  ],
  entryComponents: [
    PaymentDialogComponent, 
    ItemAddedComponent
  ],
  providers: [
    InvoiceCreateService
  ]
})
export class InvoicesModule { }
