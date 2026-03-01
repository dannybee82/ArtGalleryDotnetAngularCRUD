import { TestBed } from '@angular/core/testing';
import { StylesService } from './styles.service';
import { describe, beforeEach, it, expect } from 'vitest';

describe('StylesService', () => {
  let service: StylesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(StylesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});