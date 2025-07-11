import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ApiServiceAbstract } from '../generics/api.service-abstract.class';
import { Painting } from '../../models/painting/painting.interface';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { FilterData } from '../../models/filters/filter-data.interface';
import { PaginatedList } from '../../models/paginated-list/paginated-list.interface';

const api: string = environment.endpoint;

@Injectable({
  providedIn: 'root'
})
export class PaintingsService extends ApiServiceAbstract<Painting> {

  constructor(private http: HttpClient) {
    super({
      http: http,
      controllerName: 'Painting',
      getAllFunction: 'GetAll',
      getAllByIdFunction: '',
      getAllByIdQueryParam: '',
      getByIdFunction: 'GetById',
      getByIdQueryParam: 'id',
      createFunction: 'Create',
      updateFunction: 'Update',
      deleteFunction: 'Delete',
      deleteQueryParam: 'id',
    });
  }

  getDetailsWithThumbnail(id: number): Observable<Painting> {
    const params: HttpParams = new HttpParams().append('id', id);
    return this.http.get<Painting>(api + 'Painting/GetDetailsWithThumbnail', {params});
  }

  filterPaintings(pageNumber: number, pageSize: number, filterdata: FilterData): Observable<PaginatedList<Painting>> {
    const params = new HttpParams({ fromObject: {...filterdata} })
    .append('pageNumber', pageNumber)
    .append('pageSize', pageSize);
    return this.http.get<PaginatedList<Painting>>(api + 'Painting/Filter', {params} );
  }

  getPagedList(pageNumber: number, pageSize: number): Observable<PaginatedList<Painting>> {
    const params: HttpParams = new HttpParams()
    .append('pageNumber', pageNumber)
    .append('pageSize', pageSize);
    
    return this.http.get<PaginatedList<Painting>>(api + 'Painting/GetPagedList', {params});
  }

}