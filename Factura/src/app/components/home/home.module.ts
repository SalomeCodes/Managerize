import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home.component';
import { HomeService } from './home.service';
import { MatButtonModule } from '@angular/material/button';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

@NgModule({
  declarations: [ 
    HomeComponent
  ],
  imports: [
    CommonModule,
    MatButtonModule,
    FontAwesomeModule
  ],
  providers: [
    HomeService
  ]
})
export class HomeModule { }
