import { Component, inject, OnInit, Signal, signal, viewChild, WritableSignal } from '@angular/core';
import { AllMatModules } from '../../all-mat-modules.module';
import { RouterModule } from '@angular/router';
import { MenuItem } from '../../models/menu/menu-item.interface';
import { MediaMatcher } from '@angular/cdk/layout';
import { ScrollToTopDirective } from '../../directives/scroll-to-top.directive';
import { ScrollToTopComponent } from '../scroll-to-top/scroll-to-top.component';
import { ViewportScroller } from '@angular/common';
import { MatSidenavContent } from '@angular/material/sidenav';

@Component({
  selector: 'app-menu',
  imports: [
    AllMatModules,
    RouterModule,
    ScrollToTopDirective,
    ScrollToTopComponent
  ],
  templateUrl: './menu.component.html',
  styleUrl: './menu.component.scss'
})
export class MenuComponent implements OnInit {

  protected isCollapsed: WritableSignal<boolean> = signal(false);

  protected menuItems: WritableSignal<MenuItem[]> = signal<MenuItem[]>([
    {
      text: 'All Paintings',
      icon: 'palette',
      url: '/'
    },
    {
      text: 'Upload Image',
      icon: 'upload',
      url: '/upload-image'
    },
    {
      text: 'Add Painting',
      icon: 'add',
      url: '/create-or-update-painting'
    },
    {
      text: 'All Artists',
      icon: 'person',
      url: '/all-artists'
    },
    {
      text: 'All Styles',
      icon: 'brush',
      url: '/all-styles'
    }
  ]);

  sidenavContent: Signal<MatSidenavContent> = viewChild.required<MatSidenavContent>('sidenavContent');

  protected isScrollToTopVisible: WritableSignal<boolean> = signal(false);
  private _lastScrollPosition: WritableSignal<number> = signal(0);

  protected scroller = inject(ViewportScroller);

  protected readonly isMobile = signal(true);

  private readonly _mobileQuery: MediaQueryList;
  private readonly _mobileQueryListener: () => void;

  constructor() {
    const media = inject(MediaMatcher);

    this._mobileQuery = media.matchMedia('(max-width: 600px)');
    this.isMobile.set(this._mobileQuery.matches);
    this._mobileQueryListener = () => this.isMobile.set(this._mobileQuery.matches);
    this._mobileQuery.addEventListener('change', this._mobileQueryListener);
  }

  ngOnInit(): void {}

  onScrollStateChange(showButton: boolean): void {
    this.isScrollToTopVisible.set(this._lastScrollPosition() > 0 ? true : false);
  }  
  
  onScrollPosition(position: number): void {
    this._lastScrollPosition.set(position);
  }

  scrollToTop($event: boolean): void {
    if (this.sidenavContent()) {  
      const element = this.sidenavContent().getElementRef().nativeElement;

      element.scrollTo({  
        top: 0,  
        behavior: 'smooth'  
      });
    }
  }

}