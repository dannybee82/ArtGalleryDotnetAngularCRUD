import { TestBed } from '@angular/core/testing';
import { UploadFilesService } from './upload-files.service';
import { describe, beforeEach, it, expect } from 'vitest';

describe('UploadFilesService', () => {
  let service: UploadFilesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UploadFilesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});