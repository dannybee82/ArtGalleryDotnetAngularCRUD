import { AfterViewInit, Component, inject, signal, Signal, viewChild, WritableSignal } from "@angular/core";
import { MatPaginator, PageEvent } from "@angular/material/paginator";
import { MatTableDataSource } from "@angular/material/table";
import { ToastrService } from "ngx-toastr";

@Component({
    template: ''
})
export class SharedComponent<T> implements AfterViewInit {
    
    dataSource: MatTableDataSource<T> = new MatTableDataSource<T>([]);
    paginator: Signal<MatPaginator> = viewChild.required<MatPaginator>(MatPaginator);

    total: WritableSignal<number> = signal(0);
    pageSize: WritableSignal<number> = signal(10);
    
    protected toastr = inject(ToastrService);
    
  ngAfterViewInit() {
    if(this.paginator()) {
      this.dataSource.paginator = this.paginator();
    }
  }

  updatePagination(event: PageEvent): void {
    const isChanged: boolean = this.pageSize() !== event.pageSize ? true : false;
    this.pageSize.set(event.pageSize);
    this.dataSource.paginator = this.paginator();
    this.dataSource.paginator.pageSize = this.pageSize();

    if(isChanged) {
      this.dataSource.paginator.pageIndex = 0;
    }
  }

}