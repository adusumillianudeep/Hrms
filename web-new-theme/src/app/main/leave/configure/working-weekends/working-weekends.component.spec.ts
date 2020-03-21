import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WorkingWeekendsComponent } from './working-weekends.component';

describe('WorkingWeekendsComponent', () => {
  let component: WorkingWeekendsComponent;
  let fixture: ComponentFixture<WorkingWeekendsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WorkingWeekendsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WorkingWeekendsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
