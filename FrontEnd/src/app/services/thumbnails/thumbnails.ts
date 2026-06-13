import { HttpClient } from '@angular/common/http';
import { inject, Service } from '@angular/core';
import { environment } from '../../../environments/environment';
import { Observable } from 'rxjs';
import { Thumbnail } from '../../models/thumbnail/thumbnail.interface';

const api: string = environment.endpoint;

@Service()
export class Thumbnails {

  private http = inject(HttpClient);

  getUnusedThumbnails(): Observable<Thumbnail[]> {
    return this.http.get<Thumbnail[]>(api + 'Thumbnail/GetUnusedThumbnails');
  }

}