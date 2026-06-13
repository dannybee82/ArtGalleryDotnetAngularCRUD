import { ComponentFixture, TestBed } from '@angular/core/testing';
import { CreateOrUpdateArtist } from './create-or-update-artist';
import { describe, beforeEach, it, expect } from 'vitest';

describe('CreateOrUpdateArtistComponent', () => {
  let component: CreateOrUpdateArtist;
  let fixture: ComponentFixture<CreateOrUpdateArtist>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CreateOrUpdateArtist]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CreateOrUpdateArtist);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});