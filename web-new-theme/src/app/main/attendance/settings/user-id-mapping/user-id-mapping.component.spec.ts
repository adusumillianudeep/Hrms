import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UserIdMappingComponent } from './user-id-mapping.component';

describe('UserIdMappingComponent', () => {
  let component: UserIdMappingComponent;
  let fixture: ComponentFixture<UserIdMappingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UserIdMappingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UserIdMappingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
