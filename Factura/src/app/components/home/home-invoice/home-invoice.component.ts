import { Component, OnInit } from '@angular/core';
import { faList, faPlus } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-home-invoice',
  templateUrl: './home-invoice.component.html',
  styleUrls: ['../home.component.scss']
})
export class HomeInvoiceComponent implements OnInit {
  faList = faList;
  faPlus = faPlus;

  constructor() { }

  ngOnInit() {
  }

}
