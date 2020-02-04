import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProcessEeoFillingComponent } from './process-eeo-filling.component';

describe('ProcessEeoFillingComponent', () => {
  let component: ProcessEeoFillingComponent;
  let fixture: ComponentFixture<ProcessEeoFillingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProcessEeoFillingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProcessEeoFillingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
