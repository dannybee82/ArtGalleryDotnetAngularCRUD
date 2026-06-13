import { ComponentFixture, TestBed } from '@angular/core/testing';
import { ScrollToTop } from './scroll-to-top';
import { describe, beforeEach, it, expect } from 'vitest';

describe('ScrollToTopComponent', () => {
  let component: ScrollToTop;
  let fixture: ComponentFixture<ScrollToTop>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ScrollToTop ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ScrollToTop);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});