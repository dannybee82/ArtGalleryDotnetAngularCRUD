import { Component, HostListener, WritableSignal, signal } from '@angular/core';
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

  isVisible: WritableSignal<boolean> = signal(false);

  private max: number = document.documentElement.offsetHeight;  

  @HostListener("window:scroll", ["$event"])

  onWindowScroll() : void {
    let pos: number = (document.documentElement.scrollTop || document.body.scrollTop) + document.documentElement.offsetHeight;
    this.isVisible.set((pos - this.max > 1.0) ? true : false);
  }

  scrollToTop() : void {
    scroll(0, 0);
    this.isVisible.set(false);
  }

  scroll() : void {  
    const scrollElement = document.getElementById("scroll-to-top-element");    

    if(scrollElement != undefined) {
      scrollElement.style.visibility = 'visible';    
    } 
  }

}