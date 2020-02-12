import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DirectoryConfigurationsComponent } from './directory-configurations.component';

describe('DirectoryConfigurationsComponent', () => {
  let component: DirectoryConfigurationsComponent;
  let fixture: ComponentFixture<DirectoryConfigurationsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DirectoryConfigurationsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DirectoryConfigurationsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
