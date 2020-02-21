import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ItemsOverviewComponent } from './items-overview/items-overview.component';
import { ItemCreateComponent } from './item-create/item-create.component';

@NgModule({
  declarations: [
    ItemsOverviewComponent, 
    ItemCreateComponent
  ],
  imports: [
    CommonModule
  ]
})
export class ItemsModule { }
