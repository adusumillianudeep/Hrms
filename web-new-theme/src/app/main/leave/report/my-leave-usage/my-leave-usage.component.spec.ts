import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MyLeaveUsageComponent } from './my-leave-usage.component';

describe('MyLeaveUsageComponent', () => {
  let component: MyLeaveUsageComponent;
  let fixture: ComponentFixture<MyLeaveUsageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MyLeaveUsageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MyLeaveUsageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
