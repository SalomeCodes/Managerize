import { Component, OnInit } from '@angular/core';
import { HomeService } from './home.service';
import { Router } from '@angular/router';


@Component({
    selector: 'app-home',
    template: `
        <div class="home-content" >
            <button mat-raised-button color="primary" *ngFor="let d of modules" class="module-button" (click)="onClick(d)">
                <div>
                    <i style="font-size: 50px" class="{{d.iconDefinition}}" aria-hidden="true"></i>
                </div>
                <div>
                    {{d.title}}
                </div>
            </button>
        </div>
        `,
    styleUrls: ['./home.component.scss']
    
})
export class HomeComponent implements OnInit {

    modules: any[] = [];

    constructor(
        private homeService: HomeService,
        private router: Router
    ) { }

    ngOnInit(): void { 
        this.modules = this.homeService.getHomeModules();
    }

    onClick(module: any){
        console.log(module);
        this.modules = this.homeService.getSpecificModule(module.module);
        this.router.navigateByUrl(module.routerLink);
    }
}