import { Component, Inject } from '@angular/core';
import { MAT_SNACK_BAR_DATA } from '@angular/material/snack-bar';

@Component({
    selector: 'invoice-added-item',
    templateUrl: 'invoice-added-item.html',
    styles: [`
      .item-added-snackbar {
        color: #80cbc4;
      }
    `],
  })
  export class ItemAddedComponent {
    constructor(@Inject(MAT_SNACK_BAR_DATA) public data: any) {  }
  }