import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { faFilter, faSearch } from '@fortawesome/free-solid-svg-icons';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-search-invoice',
  templateUrl: './search-invoice.component.html',
  styleUrls: ['./search-invoice.component.scss']
})
export class SearchInvoiceComponent implements OnInit {

  constructor() { }
  
  @Input() data: any[];
  @Output() filterEntityList = new EventEmitter();
  faSearch = faSearch;
  results: any[];
  query = new FormControl();

  ngOnInit() {
  }

  searchInvoice(){
    this.results = [];

    if (this.query.value == "") {
      this.filterEntityList.emit(this.data);
    }
    else{
      console.log(this.query.value)
      this.data.filter(invoice => {
        if(
          invoice.invoiceNumber.toString().includes(this.query.value) 
          || invoice.customer.zipCode.toString().toLowerCase().includes(this.query.value.toLowerCase())
          || invoice.customer.name.toString().toLowerCase().includes(this.query.value.toLowerCase())
          || invoice.customer.surname.toString().toLowerCase().includes(this.query.value.toLowerCase())
          ){
          this.results.push(invoice);
        }
      })
      this.filterEntityList.emit(this.results);
    }
  }

}
