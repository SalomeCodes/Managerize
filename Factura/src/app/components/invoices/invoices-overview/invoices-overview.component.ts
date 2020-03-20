import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { Invoice } from 'src/app/models/Invoice';
import { PageEvent } from '@angular/material/paginator';
import { faEuroSign, faTimes, faCheck, faFilter, faSearch } from '@fortawesome/free-solid-svg-icons';
import { MatDialog } from '@angular/material/dialog';
import { PaymentDialogComponent } from './payment-dialog/payment-dialog.component';
import { InvoicesService } from 'src/app/services/invoices.service';

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

  pageSizeOptions: number[] = [];
  amountOfInvoiceItemsThatFitScreen = 5;
  oldPageIndex: Number = 0;

  pageEvent: PageEvent;

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
    this.amountOfInvoiceItemsThatFitScreen = Math.round((window.innerHeight - 225)/ 50) - 2;
    this.pageEvent = {
      length: 0,
      pageIndex: 0,
      pageSize: this.amountOfInvoiceItemsThatFitScreen
    }
    this.pageSizeOptions = [this.amountOfInvoiceItemsThatFitScreen, this.amountOfInvoiceItemsThatFitScreen *2, this.amountOfInvoiceItemsThatFitScreen*3]

    this.invoicesService.getInvoices().subscribe(invoices => {
      this.invoices = invoices;

      this.invoicesPerPage = invoices.slice(0, this.amountOfInvoiceItemsThatFitScreen);

      this.pageEvent.length = this.invoices.length;
    });
  }

  onPaginateChange(event) {
    this.invoicesPerPage = [];

    this.changeDataSourceInvoices(event);

    this.oldPageIndex = event.pageIndex;
  }

  changeDataSourceInvoices(event) {
    var startIndex = event.pageSize * event.pageIndex;

    this.invoicesPerPage = this.invoices.slice(startIndex, startIndex + event.pageSize)
  }

  search(item) {
    this.invoicesPerPage = item;
  }

  changeStatus(event) {
    this.invoicesService.getInvoicesOnPayment(event.value).subscribe(i => {
      this.invoices = i;
      this.pageEvent.length = i.length;
      this.invoicesPerPage = i.slice(0, this.pageEvent.pageSize)
    });
  }
}
