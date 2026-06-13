import { TestBed } from '@angular/core/testing';
import { Styles } from './styles';
import { describe, beforeEach, it, expect } from 'vitest';

describe('StylesService', () => {
  let service: Styles;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Styles);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});