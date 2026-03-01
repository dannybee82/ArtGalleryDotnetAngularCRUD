import { TestBed } from '@angular/core/testing';
import { AvailableFilterService } from './available-filter.service';
import { describe, beforeEach, it, expect } from 'vitest';

describe('ActiveFilterService', () => {
  let service: AvailableFilterService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AvailableFilterService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});