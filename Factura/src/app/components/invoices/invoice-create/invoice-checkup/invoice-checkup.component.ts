import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import { Customer } from 'src/app/models/Customer';
import { InvoiceLine } from 'src/app/models/InvoiceLine';
import { faEuroSign } from '@fortawesome/free-solid-svg-icons';
import { Observable } from 'rxjs/internal/Observable';
import { InvoiceCreateService } from '../invoice-create.service';

@Component({
  selector: 'app-invoice-checkup',
  templateUrl: './invoice-checkup.component.html',
  styleUrls: ['./invoice-checkup.component.scss']
})
export class InvoiceCheckupComponent implements OnChanges{
  priceAdded: boolean = false;

  ngOnChanges() {
    this.invoiceService.currentMessage.subscribe( item => 
      {
        if(item.item != null && !this.priceAdded)
        {
          this.priceAdded = true;
          this.subTotalPrice += (item.amount * item.item.price);
          this.btwPrice = (this.subTotalPrice * 0.21);
          this.totalPrice = this.btwPrice + this.subTotalPrice;
        }
      })
      this.priceAdded = false;
  }

  faEuroSign = faEuroSign;

  displayedColumns: string[] = ['description', 'amount', 'price', 'totalPrice'];
  @Input() selectedCustomer: Customer;
  @Input() invoiceLines: Observable<InvoiceLine[]>;
  date = new Date();
  subTotalPrice: number = 0; 
  btwPrice: number = 0; 
  totalPrice: number = 0; 

  constructor(
    private invoiceService: InvoiceCreateService
  ) { 
    this.subTotalPrice = 0;
  }

}
