import { AfterViewInit, Component, inject, signal, Signal, viewChild, WritableSignal } from '@angular/core';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { ToastService } from '../services/toast/toast-service';

@Component({
  template: '',
})
export class Shared<T> implements AfterViewInit {
  dataSource: MatTableDataSource<T> = new MatTableDataSource<T>([]);
  protected paginator: Signal<MatPaginator> = viewChild.required<MatPaginator>(MatPaginator);

  protected total: WritableSignal<number> = signal(0);
  protected pageSize: WritableSignal<number> = signal(10);

  protected toastr = inject(ToastService);

  ngAfterViewInit() {
    if (this.paginator()) {
      this.dataSource.paginator = this.paginator();
    }
  }

  updatePagination(event: PageEvent): void {
    const isChanged: boolean = this.pageSize() !== event.pageSize ? true : false;
    this.pageSize.set(event.pageSize);
    this.dataSource.paginator = this.paginator();
    this.dataSource.paginator.pageSize = this.pageSize();

    if (isChanged) {
      this.dataSource.paginator.pageIndex = 0;
    }
  }
}