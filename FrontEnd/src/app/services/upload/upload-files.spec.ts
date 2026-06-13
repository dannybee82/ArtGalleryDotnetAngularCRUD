import { TestBed } from '@angular/core/testing';
import { UploadFiles } from './upload-files';
import { describe, beforeEach, it, expect } from 'vitest';

describe('UploadFilesService', () => {
  let service: UploadFiles;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UploadFiles);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});