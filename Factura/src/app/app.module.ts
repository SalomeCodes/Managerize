import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

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


@NgModule({
  declarations: [
    AppComponent,
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
    ItemsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
