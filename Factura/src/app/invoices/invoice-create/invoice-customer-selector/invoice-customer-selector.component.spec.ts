import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { InvoiceCustomerSelectorComponent } from './invoice-customer-selector.component';

describe('InvoiceCustomerSelectorComponent', () => {
  let component: InvoiceCustomerSelectorComponent;
  let fixture: ComponentFixture<InvoiceCustomerSelectorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ InvoiceCustomerSelectorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(InvoiceCustomerSelectorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
