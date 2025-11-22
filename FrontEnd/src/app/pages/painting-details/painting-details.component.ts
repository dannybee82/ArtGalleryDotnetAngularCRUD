import { Component, ElementRef, inject, OnInit, Signal, signal, viewChild, WritableSignal } from '@angular/core';
import { PaintingsService } from '../../services/paintings/paintings.service';
import { catchError, EMPTY, map, Observable } from 'rxjs';
import { Painting } from '../../models/painting/painting.interface';
import { ActivatedRoute, Params } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AsyncPipe } from '@angular/common';
import { AllMatModules } from '../../all-mat-modules.module';

@Component({
  selector: 'app-painting-details',
  imports: [
    AllMatModules,
    AsyncPipe
  ],
  templateUrl: './painting-details.component.html',
  styleUrl: './painting-details.component.scss'
})
export class PaintingDetailsComponent implements OnInit {

  private _lastScrollPosition: WritableSignal<number> = signal(0);
  sidenavContent: Signal<ElementRef<HTMLElement>> = viewChild.required<ElementRef<HTMLElement>>('topOfDiv');
  isPanelCollapsed: WritableSignal<boolean> = signal(false);  

  painting$?: Observable<Painting>;

  private paintingService = inject(PaintingsService);
  private activateRoute = inject(ActivatedRoute);
  private toastr = inject(ToastrService);

  ngOnInit(): void {
    this.activateRoute.params.pipe(
      map((params: Params) => {
        if(params) {
          if(params['id']) {
            const id: number = parseInt(params['id'].toString());
            return !isNaN(id) ? id > 0 ? id : 0 : 0;
          }          
        }

        throw new Error('err');
      }),
      catchError((err) => {
        this.toastr.error('Can\'t fetch details of painting');
        return EMPTY;
      })
    ).subscribe((id: number) => {
      if(id > 0) {
        this.painting$ = this.paintingService.getById(id);
      } else {
        this.toastr.error('Can\'t fetch details of painting');
      }
    })
  }

  togglePanel(): void {  
    this.isPanelCollapsed.set(!this.isPanelCollapsed());
  }

}