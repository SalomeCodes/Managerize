import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { InvoiceItemsSelectorComponent } from './invoice-items-selector.component';

describe('InvoiceItemsSelectorComponent', () => {
  let component: InvoiceItemsSelectorComponent;
  let fixture: ComponentFixture<InvoiceItemsSelectorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ InvoiceItemsSelectorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(InvoiceItemsSelectorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
