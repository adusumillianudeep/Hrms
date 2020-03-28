import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AbsentScheduleComponent } from './absent-schedule.component';

describe('AbsentScheduleComponent', () => {
  let component: AbsentScheduleComponent;
  let fixture: ComponentFixture<AbsentScheduleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AbsentScheduleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AbsentScheduleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
