import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoadFilesInBrowserService {

  private _allowedTypes: string[] = ['image/jpg', 'image/jpeg', 'image/png', 'application/pdf', 'text/csv', 'image/gif'];

  private readonly MAX_SIZE: number = 10 * (1024 * 1024);

  readFile(file: File) : Promise<string> {
    return new Promise((resolve, reject) => {
        const fr = new FileReader();
        fr.onerror = reject;
        fr.onload = () => {
            resolve(fr.result as string);
        }
        fr.readAsDataURL(file);
    });
  }

  isValidDataType(data: string) : boolean {
    data = (data.length > 50) ? data.substring(0, 50) : data;

    if(data.toLowerCase().indexOf('base64') == -1) {
      return false;
    }

    let to: number = data.toLowerCase().indexOf('base64');
    let test: string = data.substring(0, to);

    if(this._allowedTypes.length > 0) {
      for(let i = 0; i < this._allowedTypes.length; i++) {
        let found: number = test.indexOf('data:' + this._allowedTypes[i] + ';');

        if(found > - 1) {
          return true;
        }
      }
    }
    
    return false;
  }
  
  checkMaximumSize(size: number) : boolean {
    if(size < this.MAX_SIZE) {
      return true;
    }

    return false;
  }

}