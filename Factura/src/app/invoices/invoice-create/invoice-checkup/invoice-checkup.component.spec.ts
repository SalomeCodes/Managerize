import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { InvoiceCheckupComponent } from './invoice-checkup.component';

describe('InvoiceCheckupComponent', () => {
  let component: InvoiceCheckupComponent;
  let fixture: ComponentFixture<InvoiceCheckupComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ InvoiceCheckupComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(InvoiceCheckupComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
