import { Component, OutputEmitterRef, output } from '@angular/core';
import { MatIconModule } from '@angular/material/icon';

@Component({
  selector: 'app-scroll-to-top',
  templateUrl: './scroll-to-top.component.html',
  styleUrls: ['./scroll-to-top.component.scss'],
  imports: [
    MatIconModule
  ]
})
export class ScrollToTopComponent {
  
  toTop: OutputEmitterRef<boolean> = output();

  scrollToTop(): void {
    this.toTop.emit(true);
  }

}