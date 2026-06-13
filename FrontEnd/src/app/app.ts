import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NgHttpLoaderComponent } from 'ng-http-loader';
import { Spinner } from './components/spinner/spinner';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, NgHttpLoaderComponent],
  template: `
    <ng-http-loader [entryComponent]="spinner"></ng-http-loader>
    <router-outlet />
  `
})
export class App {
  public spinner = Spinner;
  title = 'ArtGalleryDemo';
}