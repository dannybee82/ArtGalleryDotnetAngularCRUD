import { Component, InputSignal, input, OutputEmitterRef, output } from '@angular/core';
import { AllMatModules } from '../../all-mat-modules.module';

@Component({
  selector: 'app-open-file',
  templateUrl: './open-file.html',
  styleUrls: ['./open-file.scss'],
  imports: [AllMatModules],
})
export class OpenFile {
  readonly buttonText: InputSignal<string> = input<string>('');
  readonly fileExtensions: InputSignal<string> = input<string>('*');
  readonly allowMultipleSelection: InputSignal<boolean> = input<boolean>(false);
  readonly isDisabled: InputSignal<boolean> = input<boolean>(false);
  readonly matIcon: InputSignal<string> = input<string>('');

  readonly selectedFile: OutputEmitterRef<File> = output<File>();
  readonly selectedFiles: OutputEmitterRef<File[]> = output<File[]>();

  onFileSelected(event: Event) {
    if (event) {
      const element = event.target as HTMLInputElement;

      if (!this.allowMultipleSelection()) {
        if (element.files) {
          this.selectedFile.emit(element.files[0]);
        }
      } else {
        if (element.files) {
          const arr: File[] = [];

          for (let i = 0; element.files.length; i++) {
            arr.push(element.files[i]);
          }

          this.selectedFiles.emit(arr);
        }
      }
    }
  }
}