import { ViewportScroller } from '@angular/common';
import { Component, HostListener, WritableSignal, inject, signal } from '@angular/core';
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

  protected isVisible: WritableSignal<boolean> = signal(false);

  private max: number = document.documentElement.offsetHeight;  

  private scroller = inject(ViewportScroller);

  @HostListener("window:scroll",  ["$event"])
  onWindowScroll(): void {
    let pos: number = (document.documentElement.scrollTop || document.body.scrollTop) + document.documentElement.offsetHeight;    
    this.isVisible.set((pos - this.max > 1.0) ? true : false);
  }

  scrollToTop(): void {  
    this.scroller.scrollToPosition([0, 0], { behavior: 'smooth' });    
  }

}