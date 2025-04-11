import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ApiServiceAbstract } from '../generics/api.service-abstract.class';
import { Artist } from '../../models/artist/artist.interface';

@Injectable({
  providedIn: 'root'
})
export class ArtistsService extends ApiServiceAbstract<Artist> {

  constructor(private http: HttpClient) {
    super({
      http: http,
      controllerName: 'Artist',
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
