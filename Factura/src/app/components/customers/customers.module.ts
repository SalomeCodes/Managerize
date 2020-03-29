import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CustomersOverviewComponent } from './customers-overview/customers-overview.component';
import { CustomerCreateComponent } from './customer-create/customer-create.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatButtonModule } from '@angular/material/button';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatMenuModule } from '@angular/material/menu';
import { MatExpansionModule } from '@angular/material/expansion';
import { MatTableModule } from '@angular/material/table';
import { MatDialogModule } from '@angular/material/dialog';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatTooltipModule } from '@angular/material/tooltip';
import { MatStepperModule } from '@angular/material/stepper';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { CustomerDetailsComponent } from './customer-details/customer-details.component';
import { CustomerService } from 'src/app/services/customer.service';
import { TestComponent } from './test/test.component';


@NgModule({
  declarations: [
    CustomersOverviewComponent, 
    CustomerCreateComponent, CustomerDetailsComponent, TestComponent
  ],
  providers: [
    CustomerService
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
    MatSnackBarModule
  ],
  exports: [
    
  ]
})
export class CustomersModule { }
