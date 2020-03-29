import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddEmployeeDailogComponent } from './add-employee-dailog.component';

describe('AddEmployeeDailogComponent', () => {
  let component: AddEmployeeDailogComponent;
  let fixture: ComponentFixture<AddEmployeeDailogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddEmployeeDailogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddEmployeeDailogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
