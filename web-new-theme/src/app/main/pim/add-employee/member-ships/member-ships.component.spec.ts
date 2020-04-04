import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MemberShipsComponent } from './member-ships.component';

describe('MemberShipsComponent', () => {
  let component: MemberShipsComponent;
  let fixture: ComponentFixture<MemberShipsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MemberShipsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MemberShipsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
