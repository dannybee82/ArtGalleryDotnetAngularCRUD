import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ArtistsOverviewComponent } from './artists-overview.component';

describe('ArtistsOverviewComponent', () => {
  let component: ArtistsOverviewComponent;
  let fixture: ComponentFixture<ArtistsOverviewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ArtistsOverviewComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ArtistsOverviewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
