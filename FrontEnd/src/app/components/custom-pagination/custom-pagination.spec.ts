import { ComponentFixture, TestBed } from '@angular/core/testing';
import { CustomPagination } from './custom-pagination';
import { describe, beforeEach, it, expect } from 'vitest';

describe('CustomPaginationComponent', () => {
  let component: CustomPagination;
  let fixture: ComponentFixture<CustomPagination>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CustomPagination]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CustomPagination);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});