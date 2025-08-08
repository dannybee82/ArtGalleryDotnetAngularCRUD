import { Directive, HostListener, InputSignal, input, OutputEmitterRef, output } from '@angular/core';  
  
@Directive({  
  selector: '[appScrollToTop]'
})  
export class ScrollToTopDirective {  
    scrollThreshold: InputSignal<number> = input(0);

    scrollStateChange: OutputEmitterRef<boolean> = output();
    scrollPosition: OutputEmitterRef<number> = output();
  
  @HostListener('scroll', ['$event'])  
  onScroll(event: Event): void {  
    const target = event.target as HTMLElement;  
    const scrollTop = target.scrollTop;  
        
    this.scrollPosition.emit(scrollTop);  
    this.scrollStateChange.emit(scrollTop > this.scrollThreshold());  
  }  
}