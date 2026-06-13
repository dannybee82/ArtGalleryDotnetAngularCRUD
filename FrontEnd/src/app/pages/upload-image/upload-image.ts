import { Component, inject, signal, WritableSignal } from '@angular/core';
import { OpenFile } from '../../components/open-file/open-file';
import { LoadFilesInBrowser } from '../../services/other/load-files-in-browser';
import { AllMatModules } from '../../all-mat-modules.module';
import { UploadFiles } from '../../services/upload/upload-files';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-upload-image',
  imports: [AllMatModules, OpenFile],
  templateUrl: './upload-image.html',
  styleUrl: './upload-image.scss',
})
export class UploadImage {
  protected isFileValid: WritableSignal<boolean> = signal(false);
  protected imagePreview: WritableSignal<string> = signal('');

  private _uploadFile: File | undefined;

  private loadFilesInBrowser = inject(LoadFilesInBrowser);
  private uploadFileService = inject(UploadFiles);
  private toastr = inject(ToastrService);

  loadFile($event: File): void {
    this.loadFilesInBrowser.readFile($event).then((result: string | null) => {
      if (result) {
        if (
          this.loadFilesInBrowser.isValidDataType(result) &&
          this.loadFilesInBrowser.checkMaximumSize($event.size)
        ) {
          this.isFileValid.set(true);
          this.imagePreview.set(result);
          this._uploadFile = $event;
        } else {
          if (!this.loadFilesInBrowser.isValidDataType(result)) {
            this.toastr.error('File is invalid');
          } else if (this.loadFilesInBrowser.checkMaximumSize($event.size)) {
            this.toastr.error('File exceeds 10 MB');
          }
        }
      }
    });
  }

  removeFile(): void {
    this.isFileValid.set(false);
    this.imagePreview.set('');
    this._uploadFile = undefined;
  }

  uploadFile(): void {
    if (this._uploadFile) {
      this.uploadFileService.uploadFile(this._uploadFile).subscribe({
        next: (data?) => {
          this.toastr.success('File successfully uploaded,');
        },
        error: () => {
          this.toastr.error("Can't upload file.");
        },
        complete: () => {
          this.removeFile();
        },
      });
    } else {
      this.toastr.error('No File to upload.');
    }
  }
}