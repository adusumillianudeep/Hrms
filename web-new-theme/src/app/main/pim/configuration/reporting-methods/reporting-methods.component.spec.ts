import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ReportingMethodsComponent } from './reporting-methods.component';

describe('ReportingMethodsComponent', () => {
  let component: ReportingMethodsComponent;
  let fixture: ComponentFixture<ReportingMethodsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ReportingMethodsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ReportingMethodsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
