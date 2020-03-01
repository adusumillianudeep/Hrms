import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TerminationReasonsComponent } from './termination-reasons.component';

describe('TerminationReasonsComponent', () => {
  let component: TerminationReasonsComponent;
  let fixture: ComponentFixture<TerminationReasonsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TerminationReasonsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TerminationReasonsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
