import { TestBed } from '@angular/core/testing';

import { ConfigurationnService } from './configurationn.service';

describe('ConfigurationnService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ConfigurationnService = TestBed.get(ConfigurationnService);
    expect(service).toBeTruthy();
  });
});
