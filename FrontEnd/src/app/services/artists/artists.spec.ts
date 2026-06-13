import { TestBed } from '@angular/core/testing';
import { Artists } from './artists';
import { describe, beforeEach, it, expect } from 'vitest';

describe('ArtistsService', () => {
  let service: Artists;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Artists);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});