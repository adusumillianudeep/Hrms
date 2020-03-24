import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BradfordFactorComponent } from './bradford-factor.component';

describe('BradfordFactorComponent', () => {
  let component: BradfordFactorComponent;
  let fixture: ComponentFixture<BradfordFactorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BradfordFactorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BradfordFactorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
