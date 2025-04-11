import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateOrUpdateArtistComponent } from './create-or-update-artist.component';

describe('CreateOrUpdateArtistComponent', () => {
  let component: CreateOrUpdateArtistComponent;
  let fixture: ComponentFixture<CreateOrUpdateArtistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CreateOrUpdateArtistComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CreateOrUpdateArtistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});