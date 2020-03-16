import { Component, OnInit } from '@angular/core';
import { faFilter, faSearch, faEuroSign } from '@fortawesome/free-solid-svg-icons';
import { Item } from 'src/app/models/Item';
import { ItemsService } from 'src/app/services/items.service';

@Component({
  selector: 'app-items-overview',
  templateUrl: './items-overview.component.html',
  styleUrls: [
    './items-overview.component.scss',
    '../../../shared/table.component.scss'
  ]
})
export class ItemsOverviewComponent implements OnInit {
  faEuroSign = faEuroSign;
  faFilter = faFilter;
  faSearch = faSearch;

  items: Item[] = [];
  itemsPerPage: Item[] = []; 

  constructor(
    private itemService: ItemsService
  ) { }

  ngOnInit() {
    this.itemService.getItems().subscribe(items => {
      this.items = items;
      this.itemsPerPage = items;
    })
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
