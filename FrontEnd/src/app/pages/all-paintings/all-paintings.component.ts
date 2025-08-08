import { Component, inject, OnInit, signal, WritableSignal } from '@angular/core';
import { PaintingsService } from '../../services/paintings/paintings.service';
import { Painting } from '../../models/painting/painting.interface';
import { AllMatModules } from '../../all-mat-modules.module';
import { RouterLink } from '@angular/router';
import { FilterData } from '../../models/filters/filter-data.interface';
import { FiltersComponent } from '../../components/filters/filters.component';
import { CustomPaginationComponent } from '../../components/custom-pagination/custom-pagination.component';
import { PaginatedData, PaginatedList } from '../../models/paginated-list/paginated-list.interface';
import { ToastrService } from 'ngx-toastr';
import { BehaviorSubject, Observable, of } from 'rxjs';
import { AsyncPipe } from '@angular/common';
import { defaultPagination } from '../../constants/shared-default-pagination.constants';
import { FilterStore } from '../../stores/filter.store';
import { PaginationStore } from '../../stores/pagination.store';

@Component({
  selector: 'app-all-paintings',
  imports: [
    AllMatModules,
    RouterLink,
    FiltersComponent,
    CustomPaginationComponent,
    AsyncPipe
  ],
  templateUrl: './all-paintings.component.html',
  styleUrl: './all-paintings.component.scss'
})
export class AllPaintingsComponent implements OnInit {

  allPaintings$?: Observable<Painting[]>;
  protected amount: WritableSignal<number> = signal(0);

  paginationData: BehaviorSubject<PaginatedData> = new BehaviorSubject<PaginatedData>(defaultPagination);
  
  private _filterData: WritableSignal<FilterData | undefined> = signal<FilterData | undefined>(undefined);

  private paintingsService = inject(PaintingsService);
  private toastr = inject(ToastrService);
  private readonly paginationStore = inject(PaginationStore);
  private readonly filterStore = inject(FilterStore);

  ngOnInit(): void {
    this.getAllPaintings();
  }

  filterData($event: FilterData | undefined): void {
    const currentPagination: PaginatedData = this.paginationData.getValue();
    currentPagination.currentPage = 1;
    this.paginationData.next(currentPagination);    
    
    this.filterStore.update({filterOn: $event ? true : false, currentFilters: $event});
    this.paginationStore.reset();

    this.getAllPaintings();
  }

  private getAllPaintings(): void {
    const currentPagination: PaginatedData = this.paginationData.getValue();
    const currentPageIndex: number = this.paginationStore.pageIndex();
    const currentPagerSize: number = this.paginationStore.pagerSize();
    currentPagination.currentPage = currentPageIndex + 1;
    currentPagination.pageSize = currentPagerSize;

    this._filterData.set(this.filterStore.filterOn() ? this.filterStore.currentFilters() : undefined);

    const action$ = !this._filterData() ? 
       this.paintingsService.getPagedList(currentPagination.currentPage, currentPagination.pageSize) :
       this.paintingsService.filterPaintings(currentPagination.currentPage, currentPagination.pageSize, this._filterData()!);

    action$.subscribe({
      next: (data: PaginatedList<Painting>) => {
        this.allPaintings$ = of(data.items);
        const pagiationData: PaginatedData = Object.assign(data);
        this.paginationData.next(pagiationData);
        this.amount.set(data.totalCount);
      },
      error: () => {
        this.toastr.error('Can\'t fetch Paintings.');
      }
    });  
  }

  updatePagination($event: PaginatedData): void {
    this.paginationData.next($event);

    this.paginationStore.updatePageIndex($event.currentPage - 1);
    this.paginationStore.updatePageSize($event.pageSize);

    this.getAllPaintings();
  }

}