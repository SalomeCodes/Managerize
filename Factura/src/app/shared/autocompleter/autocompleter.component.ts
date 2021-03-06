import { Component, Input, Output, EventEmitter } from '@angular/core';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-autocompleter',
  templateUrl: './autocompleter.component.html',
  styleUrls: ['./autocompleter.component.scss']
})
export class AutocompleterComponent {

  @Input() entitytype: string;
  @Input() data: any[];
  @Output() filterEntityList = new EventEmitter();

  results: any[];
  // dataToReturn: any[];
  query = new FormControl();

  constructor() { }

  autocomplete() {
    this.results = [];
    if (this.query.value == "") {
      this.filterEntityList.emit(this.data);
    }
    else {
      for (let item of this.data) {
        for (let prop in item) {
          if (
            item[prop] &&
            item[prop]
              .toString()
              .toLowerCase()
              .includes(this.query.value.toLowerCase())
          ) {
            this.results.push(item);
            this.filterEntityList.emit(this.results);
            break;
          }
        }
      }
    }
  }
}

