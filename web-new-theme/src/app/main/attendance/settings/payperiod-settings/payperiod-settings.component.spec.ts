import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PayperiodSettingsComponent } from './payperiod-settings.component';

describe('PayperiodSettingsComponent', () => {
  let component: PayperiodSettingsComponent;
  let fixture: ComponentFixture<PayperiodSettingsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PayperiodSettingsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PayperiodSettingsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
