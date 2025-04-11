import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ApiServiceAbstract } from '../generics/api.service-abstract.class';
import { Style } from '../../models/style/style.interface';

@Injectable({
  providedIn: 'root'
})
export class StylesService extends ApiServiceAbstract<Style> {

  constructor(private http: HttpClient) {
    super({
      http: http,
      controllerName: 'Style',
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

}