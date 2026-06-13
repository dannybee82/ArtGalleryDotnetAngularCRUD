import { ComponentFixture, TestBed } from '@angular/core/testing';
import { Filters } from './filters';
import { describe, beforeEach, it, expect } from 'vitest';

describe('FiltersComponent', () => {
  let component: Filters;
  let fixture: ComponentFixture<Filters>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Filters]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Filters);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});