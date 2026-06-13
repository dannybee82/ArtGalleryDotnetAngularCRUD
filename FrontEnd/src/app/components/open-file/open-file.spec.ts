import { ComponentFixture, TestBed } from '@angular/core/testing';
import { OpenFile } from './open-file';
import { describe, beforeEach, it, expect } from 'vitest';

describe('OpenFileComponent', () => {
  let component: OpenFile;
  let fixture: ComponentFixture<OpenFile>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OpenFile ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(OpenFile);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});