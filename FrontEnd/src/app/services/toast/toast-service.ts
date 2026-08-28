import { Service, inject } from '@angular/core';  
import { MatSnackBar, MatSnackBarConfig } from '@angular/material/snack-bar';  
  
export type ToastType = 'success' | 'error' | 'info';  
  
@Service()  
export class ToastService {  
  private snackBar = inject(MatSnackBar);  
  
  show(message: string, type: ToastType = 'info'): void {  
    const config: MatSnackBarConfig = {  
      duration: 3500,  
      horizontalPosition: 'center',
      verticalPosition: 'bottom',
      panelClass: [`snackbar-${type}`],  
    }; 
  
    this.snackBar.open(message, undefined, config);  
  }  
}