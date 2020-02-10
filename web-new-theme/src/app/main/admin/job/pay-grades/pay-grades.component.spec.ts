import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PayGradesComponent } from './pay-grades.component';

describe('PayGradesComponent', () => {
  let component: PayGradesComponent;
  let fixture: ComponentFixture<PayGradesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PayGradesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PayGradesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
