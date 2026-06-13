import { TestBed } from '@angular/core/testing';
import { Paintings } from './paintings';
import { describe, beforeEach, it, expect } from 'vitest';

describe('PaintingsService', () => {
  let service: Paintings;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Paintings);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});