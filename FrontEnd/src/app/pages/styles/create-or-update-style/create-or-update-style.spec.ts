import { ComponentFixture, TestBed } from '@angular/core/testing';
import { CreateOrUpdateStyle } from './create-or-update-style';
import { describe, beforeEach, it, expect } from 'vitest';

describe('CreateOrUpdateStyleComponent', () => {
  let component: CreateOrUpdateStyle;
  let fixture: ComponentFixture<CreateOrUpdateStyle>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CreateOrUpdateStyle]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreateOrUpdateStyle);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});