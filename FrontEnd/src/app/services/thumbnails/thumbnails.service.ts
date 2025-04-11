import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { Observable } from 'rxjs';
import { Thumbnail } from '../../models/thumbnail/thumbnail.interface';

const api: string = environment.endpoint;

@Injectable({
  providedIn: 'root'
})
export class ThumbnailsService {

  private http = inject(HttpClient);

  getUnusedThumbnails(): Observable<Thumbnail[]> {
    return this.http.get<Thumbnail[]>(api + 'Thumbnail/GetUnusedThumbnails');
  }

}
