import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddEmployeeWizardComponent } from './add-employee-wizard.component';

describe('AddEmployeeWizardComponent', () => {
  let component: AddEmployeeWizardComponent;
  let fixture: ComponentFixture<AddEmployeeWizardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddEmployeeWizardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddEmployeeWizardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
