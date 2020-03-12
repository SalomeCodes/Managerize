import { Component, OnInit } from '@angular/core';
import { faFilter, faSearch, faEuroSign } from '@fortawesome/free-solid-svg-icons';
import { ItemsService } from '../items.service';
import { Item } from 'src/app/models/Item';

@Component({
  selector: 'app-items-overview',
  templateUrl: './items-overview.component.html',
  styleUrls: ['./items-overview.component.scss']
})
export class ItemsOverviewComponent implements OnInit {
  faEuroSign = faEuroSign;
  faFilter = faFilter;
  faSearch = faSearch;

  items: Item[] = [];
  displayedColumns: string[] = ['name', 'description', 'price'];

  constructor(
    private itemService: ItemsService
  ) { }

  ngOnInit() {
    this.itemService.getItems().subscribe(items => {
      this.items = items;
    })
  }

  search(item) {
    // this.items = item;
  }

}
