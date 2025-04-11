import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StylesOverviewComponent } from './styles-overview.component';

describe('StylesOverviewComponent', () => {
  let component: StylesOverviewComponent;
  let fixture: ComponentFixture<StylesOverviewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [StylesOverviewComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StylesOverviewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
