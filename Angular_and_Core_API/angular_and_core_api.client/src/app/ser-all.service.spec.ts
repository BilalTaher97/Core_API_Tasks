import { TestBed } from '@angular/core/testing';

import { SerAllService } from './ser-all.service';

describe('SerAllService', () => {
  let service: SerAllService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SerAllService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
