import { NgModule } from '@angular/core';
import { CommonModule, CurrencyPipe } from '@angular/common';
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

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AutocompleterComponent } from './autocompleter/autocompleter.component';
import { PaymentDialogComponent } from '../components/invoices/invoices-overview/payment-dialog/payment-dialog.component';
import { NavbarComponent } from '../layout/navbar/navbar.component';
import { LayoutModule } from '@angular/cdk/layout';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { PdfmakerComponent } from './pdfmaker/pdfmaker.component';


@NgModule({
  declarations: [
    AutocompleterComponent,
    PdfmakerComponent,
  ],
  providers: [
    CurrencyPipe
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

    LayoutModule,

    MatSidenavModule,

    MatIconModule,

    MatListModule,
  ],
  
  exports: [
    AutocompleterComponent,
    PdfmakerComponent
  ],
  entryComponents: [
    PaymentDialogComponent
  ]
})
export class SharedModule { }
