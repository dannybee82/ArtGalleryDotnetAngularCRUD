import { TestBed } from '@angular/core/testing';
import { Thumbnails } from './thumbnails';
import { describe, beforeEach, it, expect } from 'vitest';

describe('ThumbnailsService', () => {
  let service: Thumbnails;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Thumbnails);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});