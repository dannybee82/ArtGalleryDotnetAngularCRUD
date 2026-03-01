import { TestBed } from '@angular/core/testing';
import { PaintingsService } from './paintings.service';
import { describe, beforeEach, it, expect } from 'vitest';

describe('PaintingsService', () => {
  let service: PaintingsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PaintingsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});