import { TestBed } from '@angular/core/testing';

import { ThumbnailsService } from './thumbnails.service';

describe('ThumbnailsService', () => {
  let service: ThumbnailsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ThumbnailsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
