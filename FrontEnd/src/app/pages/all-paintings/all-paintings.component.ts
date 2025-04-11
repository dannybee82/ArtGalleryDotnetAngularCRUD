import { Component, inject, OnInit, signal, WritableSignal } from '@angular/core';
import { PaintingsService } from '../../services/paintings/paintings.service';
import { map, Observable, tap } from 'rxjs';
import { Painting } from '../../models/painting/painting.interface';
import { AsyncPipe } from '@angular/common';
import { AllMatModules } from '../../all-mat-modules.module';
import { RouterLink } from '@angular/router';
import { ScrollToTopComponent } from '../../components/scroll-to-top/scroll-to-top.component';
import { FilterData } from '../../models/filters/filter-data.interface';
import { FiltersComponent } from '../../components/filters/filters.component';

@Component({
  selector: 'app-all-paintings',
  imports: [
    AsyncPipe,
    AllMatModules,
    RouterLink,    
    ScrollToTopComponent,
    FiltersComponent
  ],
  templateUrl: './all-paintings.component.html',
  styleUrl: './all-paintings.component.scss'
})
export class AllPaintingsComponent implements OnInit {

  allPaintings$?: Observable<Painting[]>;
  amount: WritableSignal<number> = signal(0);

  private paintingsService = inject(PaintingsService);

  ngOnInit(): void {
    this.getAllPaintings();
  }

  filterData($event: FilterData | undefined): void {
    if($event) {
      this.getFilteredPaintings($event);
    } else {
      this.getAllPaintings();
    }
  }

  private getAllPaintings(): void {
    this.allPaintings$ = this.paintingsService.getAll<Painting>().pipe(
      tap((data) => {
        this.amount.set(data ? data.length : 0);
      }),
      map((data) => data)
    );
  }

  private getFilteredPaintings(filterData: FilterData): void {
    this.allPaintings$ = this.paintingsService.filterPaintings(filterData).pipe(
      tap((data) => {
        this.amount.set(data ? data.length : 0);
      }),
      map((data) => data)
    );
  }

}
