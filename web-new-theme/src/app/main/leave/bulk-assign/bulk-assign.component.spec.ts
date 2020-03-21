import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BulkAssignComponent } from './bulk-assign.component';

describe('BulkAssignComponent', () => {
  let component: BulkAssignComponent;
  let fixture: ComponentFixture<BulkAssignComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BulkAssignComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BulkAssignComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
