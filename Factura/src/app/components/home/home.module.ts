import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home.component';
import { HomeService } from './home.service';
import { MatButtonModule } from '@angular/material/button';

@NgModule({
  declarations: [ 
    HomeComponent
  ],
  imports: [
    CommonModule,
    MatButtonModule
  ],
  providers: [
    HomeService
  ]
})
export class HomeModule { }
