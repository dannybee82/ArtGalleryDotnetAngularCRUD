import { Component, OnInit, WritableSignal, inject, signal } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, UntypedFormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { catchError, EMPTY, map, Observable, switchMap } from 'rxjs';
import { ToastrService } from 'ngx-toastr';
import { AllMatModules } from '../../../all-mat-modules.module';
import { Artist } from '../../../models/artist/artist.interface';
import { ArtistsService } from '../../../services/artists/artists.service';
import { ObserverMessages } from '../../../models/shared/observer.messages.interface';
import { SharedObserver } from '../../../shared_methods/shared.observer';
import { RouterLink } from '@angular/router';
import { DeleteDialogData } from '../../../models/dialogs/delete-dialog-data.interface';
import { DeleteDialogComponent } from '../../../components/delete-dialog/delete-dialog.component';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-create-or-update-artist',
  standalone: true,
  imports: [
    FormsModule,
    ReactiveFormsModule,
    AllMatModules,
    RouterLink
  ],
  templateUrl: './create-or-update-artist.component.html',
  styleUrl: './create-or-update-artist.component.scss'
})
export class CreateOrUpdateArtistComponent implements OnInit {

  isUpdateMode: WritableSignal<boolean> = signal(false);
  private _updateArtist: WritableSignal<Artist | undefined> = signal(undefined);

  artistForm: UntypedFormGroup = new FormGroup({});

  private _sharedObserver: SharedObserver = new SharedObserver();

  private fb = inject(FormBuilder);
  private activeRoute = inject(ActivatedRoute);
  private router = inject(Router);
	private toastr = inject(ToastrService);
  private artistService = inject(ArtistsService);
  public dialog = inject(MatDialog);

  ngOnInit(): void {
    this.activeRoute.params.pipe(
      map((params: Params) => {
        if(params['id']) {
          const id: number = parseInt(params['id']);    
          
          if(!isNaN(id) ) {
            this.isUpdateMode.set(true);
            return id;
          }
        }
        throw new Error('No param with id');
      }),
      catchError(() => {
        this.isUpdateMode.set(false);
        return EMPTY;
      })
    ).subscribe((id: number) => {
      this.getData(id);
    });

    this.artistForm = this.fb.group({
      name: ['', Validators.required],
      description: ['', Validators.required],
      yearOfBirth: [1980, [Validators.required, Validators.min(1400), Validators.max(2025)]],
      yearOfDeath: [''],
    });
  }

  submit(): void {
    if(this.artistForm.valid) {
      const artist: Artist = Object.assign(this.artistForm.value);

      if(this.isUpdateMode() && this._updateArtist()) {
        artist.id = this._updateArtist()!.id;
      }
      
      const dod: string =  this.artistForm.controls['yearOfDeath'].value === null ? '' : this.artistForm.controls['yearOfDeath'].value.toString();

      if(dod !== '') {
        let parsed: number = parseInt(dod);

        if(isNaN(parsed) || parsed < 1200 || parsed > 2050) {
          this.toastr.error('Invalid year for: Year of Death');
          return;
        } else {
          artist.yearOfDeath = parsed;
        }
      } else {
        artist.yearOfDeath = undefined;
      }

      const action$: Observable<void> = this.isUpdateMode() ?
        this.artistService.update(artist): 
        this.artistService.create(artist);

      const messages: ObserverMessages = {
        createSucces: 'Artist successfully created',
        createError: 'Can\'t create Artist',
        updateSuccess: 'Artist successfully updated',
        updateError: 'Can\'t update Artist'
      };

      action$.subscribe(this._sharedObserver.getObserver(this.isUpdateMode(), messages, ['/all-artists']));
    } else {
      this.artistForm.markAllAsTouched();
      this.toastr.error('Form invalid.');
    }
  }

  deleteArtist(): void {
    if(this._updateArtist()) {
      const dialogData: DeleteDialogData = {
        title: 'Delete Artist',
        message: 'Do you want to the delete the Artist below?',
        additionalData: `${this._updateArtist()?.name} - ${this._updateArtist()?.yearOfBirth} - ${this._updateArtist()?.yearOfDeath}`,
        confirmDelete: false
      };
  
      const dialog = this.dialog.open(DeleteDialogComponent, {data: dialogData});
    
      const result$: Observable<void> = dialog.afterClosed().pipe(
        switchMap((data: DeleteDialogData) => {
          if(data) {
            if(data.confirmDelete) {
              return this.artistService.delete<Artist>(this._updateArtist()?.id ?? 0); 
            }            
          }
              
          return EMPTY;
        })
      );
          
      result$.subscribe({
        next: () => {
          this.toastr.success('Artist successfully deleted');
          this.router.navigate(['/']);
        },
        error: () => {
          this.toastr.error('Can\'t delete Artist');
        }
      });      
    } else {
      this.toastr.error('There is no Artist loaded.');
    }
  }

  private getData(id: number): void {
    this.artistService.getById<Artist>(id).subscribe({
      next: (data: Artist) => {
        this._updateArtist.set(data);
      },
      error: () => {
        this.toastr.error('Can\'t fetch Artist Details');
      },
      complete: () => {
        if(this._updateArtist()) {
          this.artistForm.patchValue(this._updateArtist()!);
        }
      }
    });
  }

}