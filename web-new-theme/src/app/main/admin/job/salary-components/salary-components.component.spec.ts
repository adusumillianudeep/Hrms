import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SalaryComponentsComponent } from './salary-components.component';

describe('SalaryComponentsComponent', () => {
  let component: SalaryComponentsComponent;
  let fixture: ComponentFixture<SalaryComponentsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SalaryComponentsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SalaryComponentsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
