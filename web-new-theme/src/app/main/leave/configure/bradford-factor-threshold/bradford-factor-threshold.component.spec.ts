import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BradfordFactorThresholdComponent } from './bradford-factor-threshold.component';

describe('BradfordFactorThresholdComponent', () => {
  let component: BradfordFactorThresholdComponent;
  let fixture: ComponentFixture<BradfordFactorThresholdComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BradfordFactorThresholdComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BradfordFactorThresholdComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
