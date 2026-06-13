import { ComponentFixture, TestBed } from '@angular/core/testing';
import { CreatePainting } from './create-painting';
import { describe, beforeEach, it, expect } from 'vitest';

describe('CreatePaintingComponent', () => {
  let component: CreatePainting;
  let fixture: ComponentFixture<CreatePainting>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CreatePainting]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CreatePainting);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});