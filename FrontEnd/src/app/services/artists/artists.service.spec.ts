import { TestBed } from '@angular/core/testing';
import { ArtistsService } from './artists.service';
import { describe, beforeEach, it, expect } from 'vitest';

describe('ArtistsService', () => {
  let service: ArtistsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ArtistsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});