import { ComponentFixture, TestBed } from '@angular/core/testing';
import { CreateOrUpdateStyleComponent } from './create-or-update-style.component';
import { describe, beforeEach, it, expect } from 'vitest';

describe('CreateOrUpdateStyleComponent', () => {
  let component: CreateOrUpdateStyleComponent;
  let fixture: ComponentFixture<CreateOrUpdateStyleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CreateOrUpdateStyleComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreateOrUpdateStyleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});