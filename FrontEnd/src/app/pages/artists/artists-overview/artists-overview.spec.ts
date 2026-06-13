import { ComponentFixture, TestBed } from '@angular/core/testing';
import { ArtistsOverview } from './artists-overview';
import { describe, beforeEach, it, expect } from 'vitest';

describe('ArtistsOverviewComponent', () => {
  let component: ArtistsOverview;
  let fixture: ComponentFixture<ArtistsOverview>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ArtistsOverview]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ArtistsOverview);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});