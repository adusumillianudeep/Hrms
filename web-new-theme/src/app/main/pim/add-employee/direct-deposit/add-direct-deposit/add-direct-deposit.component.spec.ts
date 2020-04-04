import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddDirectDepositComponent } from './add-direct-deposit.component';

describe('AddDirectDepositComponent', () => {
  let component: AddDirectDepositComponent;
  let fixture: ComponentFixture<AddDirectDepositComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddDirectDepositComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddDirectDepositComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
