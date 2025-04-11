import { inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';

const api: string = environment.endpoint;

@Injectable({
  providedIn: 'root'
})
export class UploadFilesService {

  private http = inject(HttpClient);

  uploadFile(file: File): Observable<any> {
    const input = new FormData();
    input.append('clientDate', new Date().toJSON());
    input.append('file', file, file.name);

    return this.http.post<any>(api + 'UploadImage/UploadImage', input);
  }

}