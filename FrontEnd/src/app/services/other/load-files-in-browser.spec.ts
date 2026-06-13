import { TestBed } from '@angular/core/testing';
import { LoadFilesInBrowser } from './load-files-in-browser';
import { describe, beforeEach, it, expect } from 'vitest';

describe('LoadFilesInBrowserService', () => {
  let service: LoadFilesInBrowser;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(LoadFilesInBrowser);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});