import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
import { Invoice } from 'src/app/models/Invoice';
import { InvoicesService } from 'src/app/services/invoices.service';

@Component({
  selector: 'app-payment-dialog',
  templateUrl: './payment-dialog.component.html',
  styleUrls: ['./payment-dialog.component.scss']
})
export class PaymentDialogComponent{


  constructor(
    public dialogRef: MatDialogRef<PaymentDialogComponent>,
    private invoiceService: InvoicesService,
    @Inject(MAT_DIALOG_DATA) public data: Invoice) 
  {  }

  onCancel(): void {
    this.dialogRef.close();
  }
  onAddPayment(data: number): void {
    this.data.payedAmount += data;
    if((this.data.totalPrice - this.data.payedAmount) <= 0)
      this.data.datePayed = new Date();

    this.invoiceService.addPayment(this.data).subscribe(invoice => console.log(invoice))
    this.dialogRef.close();
  }

}

