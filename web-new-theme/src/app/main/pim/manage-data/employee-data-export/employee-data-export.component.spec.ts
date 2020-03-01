import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeeDataExportComponent } from './employee-data-export.component';

describe('EmployeeDataExportComponent', () => {
  let component: EmployeeDataExportComponent;
  let fixture: ComponentFixture<EmployeeDataExportComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EmployeeDataExportComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EmployeeDataExportComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
