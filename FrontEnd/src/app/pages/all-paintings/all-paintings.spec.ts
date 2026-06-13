import { ComponentFixture, TestBed } from '@angular/core/testing';
import { AllPaintings } from './all-paintings';
import { describe, beforeEach, it, expect } from 'vitest';

describe('AllPaintingsComponent', () => {
  let component: AllPaintings;
  let fixture: ComponentFixture<AllPaintings>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AllPaintings]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AllPaintings);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});