import { Component, OnInit } from '@angular/core';
import { faFileInvoice, faUsers, faGifts } from '@fortawesome/free-solid-svg-icons';

@Component({
selector: 'app-home',
templateUrl: './home.component.html',
styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
faFileInvoice = faFileInvoice;
faUsers = faUsers;
faGifts = faGifts;
constructor() { }

ngOnInit() {
}

}
