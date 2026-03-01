import { TestBed } from '@angular/core/testing';
import { LoadFilesInBrowserService } from './load-files-in-browser.service';
import { describe, beforeEach, it, expect } from 'vitest';

describe('LoadFilesInBrowserService', () => {
  let service: LoadFilesInBrowserService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(LoadFilesInBrowserService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});