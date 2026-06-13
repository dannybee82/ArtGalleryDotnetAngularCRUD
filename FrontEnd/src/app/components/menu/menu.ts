import { Component, inject, OnDestroy, OnInit, Signal, signal, viewChild, WritableSignal } from '@angular/core';
import { AllMatModules } from '../../all-mat-modules.module';
import { RouterModule } from '@angular/router';
import { MenuItem } from '../../models/menu/menu-item.interface';
import { MediaMatcher } from '@angular/cdk/layout';
import { ScrollToTopDirective } from '../../directives/scroll-to-top.directive';
import { ScrollToTop } from '../scroll-to-top/scroll-to-top';
import { ViewportScroller } from '@angular/common';
import { MatSidenavContent } from '@angular/material/sidenav';
import { fromEvent, Observable, Subscription } from 'rxjs';

@Component({
  selector: 'app-menu',
  imports: [AllMatModules, RouterModule, ScrollToTopDirective, ScrollToTop],
  templateUrl: './menu.html',
  styleUrl: './menu.scss',
})
export class Menu implements OnInit, OnDestroy {
  protected isCollapsed: WritableSignal<boolean> = signal(false);
  protected disableResizing: WritableSignal<boolean> = signal(false);

  protected menuItems: WritableSignal<MenuItem[]> = signal<MenuItem[]>([
    {
      text: 'All Paintings',
      icon: 'palette',
      url: '/',
    },
    {
      text: 'Upload Image',
      icon: 'upload',
      url: '/upload-image',
    },
    {
      text: 'Add Painting',
      icon: 'add',
      url: '/create-or-update-painting',
    },
    {
      text: 'All Artists',
      icon: 'person',
      url: '/all-artists',
    },
    {
      text: 'All Styles',
      icon: 'brush',
      url: '/all-styles',
    },
  ]);

  sidenavContent: Signal<MatSidenavContent> =
    viewChild.required<MatSidenavContent>('sidenavContent');

  protected isScrollToTopVisible: WritableSignal<boolean> = signal(false);
  private _lastScrollPosition: WritableSignal<number> = signal(0);

  protected readonly isMobile = signal(true);

  private readonly _mobileQuery: MediaQueryList;
  private readonly _mobileQueryListener: () => void;

  private _resizeObservable$?: Observable<Event>;
  private _resizeSubscription$?: Subscription;

  protected scroller = inject(ViewportScroller);

  constructor() {
    const media = inject(MediaMatcher);

    this._mobileQuery = media.matchMedia('(max-width: 600px)');
    this.isMobile.set(this._mobileQuery.matches);
    this._mobileQueryListener = () => this.isMobile.set(this._mobileQuery.matches);
    this._mobileQuery.addEventListener('change', this._mobileQueryListener);

    this.isCollapsed.set(window.innerWidth <= 959 ? true : false);
    this.disableResizing.set(window.innerWidth <= 959 ? true : false);
  }

  ngOnInit(): void {
    this._resizeObservable$ = fromEvent(window, 'resize');
    this._resizeSubscription$ = this._resizeObservable$.subscribe((evt) => {
      this.isCollapsed.set(window.innerWidth <= 959 ? true : false);
      this.disableResizing.set(window.innerWidth <= 959 ? true : false);
    });
  }

  ngOnDestroy(): void {
    if (this._resizeSubscription$) {
      this._resizeSubscription$!.unsubscribe();
    }
  }

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
        behavior: 'smooth',
      });
    }
  }
}