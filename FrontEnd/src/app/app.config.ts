import { ApplicationConfig, provideZonelessChangeDetection } from '@angular/core';
import { provideRouter } from '@angular/router';
import { routes } from './app.routes';
import { provideAnimations } from '@angular/platform-browser/animations';
import { pendingRequestsInterceptor$ } from 'ng-http-loader';
import { provideHttpClient, withInterceptors, withXhr } from '@angular/common/http';
import { provideStore } from '@ngrx/store';
import { MAT_SNACK_BAR_DEFAULT_OPTIONS } from '@angular/material/snack-bar';

export const appConfig: ApplicationConfig = {
  providers: [
    provideZonelessChangeDetection(),
    provideRouter(routes),
    provideHttpClient(withXhr(), withInterceptors([pendingRequestsInterceptor$])),
    provideAnimations(),    
    { 
      provide: MAT_SNACK_BAR_DEFAULT_OPTIONS, 
      useValue: { 
        horizontalPosition: 'center', 
        verticalPosition: 'bottom', 
        duration: 3500 
      } 
    },
    provideStore()
  ],
};