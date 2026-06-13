import { ComponentFixture, TestBed } from '@angular/core/testing';
import { PaintingDetails } from './painting-details';
import { describe, beforeEach, it, expect } from 'vitest';

describe('PaintingDetailsComponent', () => {
  let component: PaintingDetails;
  let fixture: ComponentFixture<PaintingDetails>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PaintingDetails]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PaintingDetails);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});