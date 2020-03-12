import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { InvoicesService } from '../invoices.service';
import { Invoice } from 'src/app/models/Invoice';
import { PageEvent } from '@angular/material/paginator';
import { faEuroSign, faTimes, faCheck, faFilter, faSearch } from '@fortawesome/free-solid-svg-icons';
import { MatDialog } from '@angular/material/dialog';
import { PaymentDialogComponent } from './payment-dialog/payment-dialog.component';

@Component({
  selector: 'app-invoices-overview',
  templateUrl: './invoices-overview.component.html',
  styleUrls: ['./invoices-overview.component.scss']
})
export class InvoicesOverviewComponent implements OnInit {
  faEuroSign = faEuroSign;
  faTimes = faTimes;
  faCheck = faCheck;
  faFilter = faFilter;
  faSearch = faSearch;
  
  invoices: Invoice[] = [];
  invoicesPerPage: Invoice[] = [];

  displayedColumns: string[] = ['description', 'amount', 'price'];
  pageSizeOptions: number[] = [4, 8, 16, 32];
  oldPageIndex: Number = 0;
  pageEvent: PageEvent = {
    length: 0,
    pageIndex: 0,
    pageSize: 4
  };

  constructor(
    private invoicesService: InvoicesService,
    public dialog: MatDialog
    ) { }

    openDialog(inv: Invoice): void {
      this.dialog.open(PaymentDialogComponent, {
        width: '255px',
        data: inv
      });
    }

  setPageSizeOptions(setPageSizeOptionsInput: string) {
    this.pageSizeOptions = setPageSizeOptionsInput.split(',').map(str => +str);
  }

  ngOnInit() {
    this.invoicesService.getInvoices().subscribe(invoices => {
      this.invoices = invoices;

      for (var i = 0; i < invoices.length && i < 4; i++) {
        console.log('invoice')
        this.invoicesPerPage.push(invoices[i])
      }

      this.pageEvent.length = invoices.length;
    });
  }

  onPaginateChange(event){
    this.invoicesPerPage = [];
        
    this.changeDataSourceInvoices(event);

    this.oldPageIndex = event.pageIndex;
  }

  changeDataSourceInvoices(event){
    for (var _i = 0; _i <= event.pageSize - 1; _i++) {
      var position = event.pageIndex * 4;
      var invoiceIndex = position + _i;
      if(invoiceIndex < this.invoices.length)
        this.invoicesPerPage.push(this.invoices[invoiceIndex]);
    }
  }

  search(item) {
    this.invoicesPerPage = item;
	}
}
