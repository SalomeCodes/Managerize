import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { ItemsService } from 'src/app/services/items.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-item-create',
  templateUrl: './item-create.component.html',
  styleUrls: ['./item-create.component.scss']
})
export class ItemCreateComponent implements OnInit {
  itemForm = new FormGroup({
    name: new FormControl(''),
    price: new FormControl(''),
    description: new FormControl('')
  });

  constructor(
    public itemService: ItemsService,
    public router: Router
  ) { }

  ngOnInit() {
  }

  onSubmit() {
    this.itemService.addItem(this.itemForm.value).subscribe(data => {
      this.router.navigateByUrl("/items");
    });
  }
}
