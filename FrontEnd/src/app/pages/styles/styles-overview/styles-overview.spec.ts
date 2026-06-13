import { ComponentFixture, TestBed } from '@angular/core/testing';
import { StylesOverview } from './styles-overview';
import { describe, beforeEach, it, expect } from 'vitest';

describe('StylesOverviewComponent', () => {
  let component: StylesOverview;
  let fixture: ComponentFixture<StylesOverview>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [StylesOverview]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StylesOverview);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});