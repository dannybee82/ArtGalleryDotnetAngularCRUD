import { Component, inject, OnInit } from '@angular/core';
import { PaintingsService } from '../../services/paintings/paintings.service';
import { catchError, EMPTY, map, Observable } from 'rxjs';
import { Painting } from '../../models/painting/painting.interface';
import { ActivatedRoute, Params } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AsyncPipe } from '@angular/common';
import { AllMatModules } from '../../all-mat-modules.module';
import { ScrollToTopComponent } from '../../components/scroll-to-top/scroll-to-top.component';

@Component({
  selector: 'app-painting-details',
  imports: [
    AllMatModules,
    AsyncPipe,
    ScrollToTopComponent
  ],
  templateUrl: './painting-details.component.html',
  styleUrl: './painting-details.component.scss'
})
export class PaintingDetailsComponent implements OnInit {

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

}