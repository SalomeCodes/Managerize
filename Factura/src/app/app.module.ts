import { BrowserModule } from '@angular/platform-browser';
import { NgModule, LOCALE_ID } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { MatButtonModule } from '@angular/material/button';
import { InvoicesModule } from './components/invoices/invoices.module';
import { SharedModule } from './shared/shared.module';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { HomeModule } from './components/home/home.module';
import { CustomersModule } from './components/customers/customers.module';
import { ItemsModule } from './components/items/items.module';
import { registerLocaleData, CurrencyPipe } from '@angular/common';
import localeNl from '@angular/common/locales/nl';
import { NavbarComponent } from './layout/navbar/navbar.component';
import { LayoutModule } from '@angular/cdk/layout';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
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
import { MatToolbarModule } from '@angular/material/toolbar';
import { ContentLayoutComponent } from './layout/content-layout/content-layout.component';

registerLocaleData(localeNl, 'nl');


@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent, 
    ContentLayoutComponent,
    // CurrencyPipe
  ],
  imports: [
    BrowserModule,
    FontAwesomeModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatButtonModule,
    SharedModule,
    InvoicesModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    HomeModule,
    CustomersModule,
    ItemsModule,
    LayoutModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule,
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
  ],
  providers: [
    {provide: LOCALE_ID, useValue: 'nl-NL'}
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
