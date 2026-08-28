import { Component, ElementRef, inject, OnInit, Signal, signal, viewChild, WritableSignal } from '@angular/core';
import { Paintings } from '../../services/paintings/paintings';
import { catchError, EMPTY, map, Observable } from 'rxjs';
import { Painting } from '../../models/painting/painting.interface';
import { ActivatedRoute, Params } from '@angular/router';
import { AsyncPipe } from '@angular/common';
import { AllMatModules } from '../../all-mat-modules.module';
import { ToastService } from '../../services/toast/toast-service';

@Component({
  selector: 'app-painting-details',
  imports: [AllMatModules, AsyncPipe],
  templateUrl: './painting-details.html',
  styleUrl: './painting-details.scss',
})
export class PaintingDetails implements OnInit {  
  sidenavContent: Signal<ElementRef<HTMLElement>> =
    viewChild.required<ElementRef<HTMLElement>>('topOfDiv');
  isPanelCollapsed: WritableSignal<boolean> = signal(false);

  painting$?: Observable<Painting>;

  private paintingService = inject(Paintings);
  private activateRoute = inject(ActivatedRoute);
  private toastr = inject(ToastService);

  ngOnInit(): void {
    this.activateRoute.params
      .pipe(
        map((params: Params) => {
          if (params) {
            if (params['id']) {
              const id: number = parseInt(params['id'].toString());
              return !isNaN(id) ? (id > 0 ? id : 0) : 0;
            }
          }

          throw new Error('err');
        }),
        catchError((err) => {
          this.toastr.show('Can\'t fetch details of painting', 'error');
          return EMPTY;
        }),
      )
      .subscribe((id: number) => {
        if (id > 0) {
          this.painting$ = this.paintingService.getById(id);
        } else {
          this.toastr.show('Can\'t fetch details of painting', 'error');
        }
      });
  }

  togglePanel(): void {
    this.isPanelCollapsed.set(!this.isPanelCollapsed());
  }
}