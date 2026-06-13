import { Component, OutputEmitterRef, output } from '@angular/core';
import { MatIconModule } from '@angular/material/icon';

@Component({
  selector: 'app-scroll-to-top',
  templateUrl: './scroll-to-top.html',
  styleUrls: ['./scroll-to-top.scss'],
  imports: [MatIconModule],
})
export class ScrollToTop {
  toTop: OutputEmitterRef<boolean> = output();

  scrollToTop(): void {
    this.toTop.emit(true);
  }
}