import { TestBed } from '@angular/core/testing';
import { ToastService } from './toast-service';
import { beforeEach, describe, expect, it } from 'vitest';

describe('ToastService', () => {
  let service: ToastService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ToastService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
