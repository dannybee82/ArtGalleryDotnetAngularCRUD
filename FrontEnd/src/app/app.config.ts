import { ApplicationConfig, provideZoneChangeDetection, provideZonelessChangeDetection } from '@angular/core';
import { provideRouter } from '@angular/router';
import { routes } from './app.routes';
import { provideAnimations } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { pendingRequestsInterceptor$ } from 'ng-http-loader';
import { importProvidersFrom } from '@angular/core';
import { provideHttpClient, withInterceptors } from '@angular/common/http';

export const appConfig: ApplicationConfig = {
  providers: [		
		provideZonelessChangeDetection(),
		provideRouter(routes),
		provideHttpClient(
			withInterceptors([pendingRequestsInterceptor$])
		),
		provideAnimations(), 
		importProvidersFrom(ToastrModule.forRoot({ positionClass: 'toast-bottom-center' })),
	]
};