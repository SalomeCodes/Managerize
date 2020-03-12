import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { Item } from 'src/app/models/Item';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ItemAddedComponent } from './invoice-added-item-snackbar/invoice-added-item';
import { faFilter, faPlusCircle } from '@fortawesome/free-solid-svg-icons';
import { InvoiceLine } from 'src/app/models/InvoiceLine';
import { InvoiceCreateService } from '../invoice-create.service';
import { ItemsService } from 'src/app/services/items.service';

@Component({
  selector: 'app-invoice-items-selector',
  templateUrl: './invoice-items-selector.component.html',
  styleUrls: ['./invoice-items-selector.component.scss']
})
export class InvoiceItemsSelectorComponent implements OnInit {
  faPlus = faPlusCircle;

  items: Item[];
  itemsPerPage: Item[];
  displayedColumns: string[] = ['naam', 'beschrijving', 'stuksprijs', 'aantal'];

  @Output() invoiceLines = new EventEmitter<InvoiceLine>();


  constructor(
    private itemService: ItemsService,
    private _snackbar: MatSnackBar,
    private invoiceService: InvoiceCreateService
    ) { }

  ngOnInit() {
    this.itemService.getItems().subscribe(i => 
      {
        this.items = i;
        this.itemsPerPage = this.items;
      });
  }

  selectItem(item: any, amount: any){
    let invoiceLine = new InvoiceLine();
    invoiceLine.item = item;
    invoiceLine.amount = amount;

    this.invoiceService.addInvoiceLine(invoiceLine);
    
    this.invoiceLines.emit(invoiceLine);

    this._snackbar.openFromComponent(ItemAddedComponent, {
      duration: 5 * 1000,
      data: item,
      horizontalPosition: 'right'
    });
  }

  search(item) {
    if(item.length < 1){
      this.itemsPerPage = this.items;
    }
    else{
      this.itemsPerPage = item;
    }
  }

}