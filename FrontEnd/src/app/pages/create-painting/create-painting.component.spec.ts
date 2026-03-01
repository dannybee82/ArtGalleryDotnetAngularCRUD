import { ComponentFixture, TestBed } from '@angular/core/testing';
import { CreatePaintingComponent } from './create-painting.component';
import { describe, beforeEach, it, expect } from 'vitest';

describe('CreatePaintingComponent', () => {
  let component: CreatePaintingComponent;
  let fixture: ComponentFixture<CreatePaintingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CreatePaintingComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CreatePaintingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});