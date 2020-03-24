import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CalendarConfigurationComponent } from './calendar-configuration.component';

describe('CalendarConfigurationComponent', () => {
  let component: CalendarConfigurationComponent;
  let fixture: ComponentFixture<CalendarConfigurationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CalendarConfigurationComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CalendarConfigurationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
