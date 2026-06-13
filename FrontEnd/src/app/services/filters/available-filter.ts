import { HttpClient, HttpParams } from '@angular/common/http';
import { inject, Service } from '@angular/core';
import { environment } from '../../../environments/environment';
import { FilterData } from '../../models/filters/filter-data.interface';
import { Observable } from 'rxjs';
import { FiltersAvailable } from '../../models/filters/filters-available.interface';

const api: string = environment.endpoint;

@Service()
export class AvailableFilter {

  private http = inject(HttpClient);

  getAvailableFilters(filterdata: FilterData): Observable<FiltersAvailable> {
    const params = new HttpParams({ fromObject: {...filterdata} });
    return this.http.get<FiltersAvailable>(api + 'AvailableFilter/GetAvailableFilters', {params} );
  }

}