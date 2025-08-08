import { Component, OnInit, WritableSignal, inject, signal } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, UntypedFormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { catchError, EMPTY, forkJoin, map, Observable, of, switchMap } from 'rxjs';
import { ToastrService } from 'ngx-toastr';
import { AllMatModules } from '../../all-mat-modules.module';
import { PaintingsService } from '../../services/paintings/paintings.service';
import { ArtistsService } from '../../services/artists/artists.service';
import { StylesService } from '../../services/style/styles.service';
import { Artist } from '../../models/artist/artist.interface';
import { Style } from '../../models/style/style.interface';
import { Painting } from '../../models/painting/painting.interface';
import { ThumbnailsService } from '../../services/thumbnails/thumbnails.service';
import { Thumbnail } from '../../models/thumbnail/thumbnail.interface';
import { SharedObserver } from '../../shared_methods/shared.observer';
import { ObserverMessages } from '../../models/shared/observer.messages.interface';
import { RouterLink } from '@angular/router';
import { DeleteDialogData } from '../../models/dialogs/delete-dialog-data.interface';
import { MatDialog } from '@angular/material/dialog';
import { DeleteDialogComponent } from '../../components/delete-dialog/delete-dialog.component';
import { FilterStore } from '../../stores/filter.store';
import { PaginationStore } from '../../stores/pagination.store';

@Component({
  selector: 'app-create-painting',
  standalone: true,
  imports: [
    FormsModule,
    ReactiveFormsModule,
    AllMatModules,
    RouterLink
  ],
  templateUrl: './create-painting.component.html',
  styleUrl: './create-painting.component.scss'
})
export class CreatePaintingComponent implements OnInit {

  protected isUpdateMode: WritableSignal<boolean> = signal(false);
  protected isLoaded: WritableSignal<boolean> = signal(false);
  
  protected allArtists: WritableSignal<Artist[]> = signal([]);
  protected allStyles: WritableSignal<Style[]> = signal([]);
  protected allUnusedThumbnails: WritableSignal<Thumbnail[]> = signal([]);
  private _updatePainting: WritableSignal<Painting | undefined> = signal(undefined);

  protected selectedArtist: WritableSignal<Artist | undefined> = signal(undefined);
  protected selectedStyle: WritableSignal<Style | undefined>= signal(undefined);
  protected selectedThumbnail: WritableSignal<Thumbnail | undefined> = signal(undefined);

  paintingForm: UntypedFormGroup = new FormGroup({});
  artistForm: UntypedFormGroup = new FormGroup({});
  styleForm: UntypedFormGroup = new FormGroup({});
  thumbnailForm: UntypedFormGroup = new FormGroup({});

  private _sharedObserver: SharedObserver = new SharedObserver();

  private fb = inject(FormBuilder);
  private activeRoute = inject(ActivatedRoute);
  private router = inject(Router);
	private toastr = inject(ToastrService);
  private paintingsService = inject(PaintingsService);
  private artistService = inject(ArtistsService);
  private stylesService = inject(StylesService);
  private thumbnailsService = inject(ThumbnailsService);
  public dialog = inject(MatDialog);
  private readonly filterStore = inject(FilterStore);
  private readonly paginationStore = inject(PaginationStore);

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

    this.paintingForm = this.fb.group({
      name: ['', Validators.required],
      description: ['', Validators.required],
      year: ['', [Validators.required, Validators.min(1200), Validators.max(2050)]],
    });

    this.artistForm = this.fb.group({
      selectedArtist: [null, Validators.required]
    });

    this.styleForm = this.fb.group({
      selectedStyle: [null, Validators.required]
    });

    this.thumbnailForm = this.fb.group({
      selectedThumbnail: [null, Validators.required]
    });

    this.artistForm.controls['selectedArtist'].valueChanges.subscribe((artist: Artist) => {
      if(artist) {
        this.selectedArtist.set(artist);
      }
    });

    this.styleForm.controls['selectedStyle'].valueChanges.subscribe((style: Style) => {
      if(style) {
        this.selectedStyle.set(style);
      }
    });

    this.thumbnailForm.controls['selectedThumbnail'].valueChanges.subscribe((thumbnail: Thumbnail) => {
      if(thumbnail) {
        this.selectedThumbnail.set(thumbnail);
      }
    });

    if(!this.isUpdateMode()) {
      this.getData();
    }

    this._sharedObserver.getRefresh().subscribe((isRefresh: boolean) => {
      if(isRefresh && !this.isUpdateMode()) {
        //Reset pagination and pager.
        this.filterStore.reset();
        this.paginationStore.reset();
      }
    });
  }

  submit(): void {
    if(this.paintingForm.valid && this.artistForm.valid && this.styleForm.valid && this.selectedThumbnail()) {
      const action$: Observable<void> = this.isUpdateMode() ?
        this.paintingsService.update(this.assignValues()) :
        this.paintingsService.create(this.assignValues());

      const message: ObserverMessages = {
        createSucces: 'Painting successfully created',
        createError: 'Can\'t create Painting',
        updateSuccess: 'Painting successfully updated.',
        updateError: 'Can\'t update Painting'
      };
      
      action$.subscribe(this._sharedObserver.getObserver(this.isUpdateMode(), message, ['/']));
    } else {
      this.paintingForm.markAllAsTouched();
      this.artistForm.markAllAsTouched();
      this.styleForm.markAllAsTouched();
      this.thumbnailForm.markAllAsTouched();
      this.toastr.error('Form invalid.');
    }
  }

  compareObj(o1: Artist | Style, o2: Artist | Style): boolean {
    if(o1 && o2) {
      return o1.id === o2.id;
    }

    return false;
  }

  deletePainting(): void {
    if(this._updatePainting()) {
      const dialogData: DeleteDialogData = {
        title: 'Delete Painting',
        message: 'Do you want to the delete the Painting below?',
        additionalData: `${this._updatePainting()?.name} - ${this._updatePainting()?.artist?.name} - ${this._updatePainting()?.year}`,
        confirmDelete: false
      };

      const dialog = this.dialog.open(DeleteDialogComponent, {data: dialogData});

      const result$: Observable<void> = dialog.afterClosed().pipe(
        switchMap((data: DeleteDialogData) => {
          if(data) {
            if(data.confirmDelete) {
              return this.paintingsService.delete<Painting>(this._updatePainting()?.id ?? 0); 
            }            
          }
          
          return EMPTY;
        })
      );
      
      result$.subscribe({
        next: () => {
          this.toastr.success('Painting successfully deleted');
          
          //Reset pagination.
          this.paginationStore.reset();          
          this.router.navigate(['/']);
        },
        error: () => {
          this.toastr.error('Can\'t delete Painting');
        }
      });      
    } else {
      this.toastr.error('There is no Painting loaded.');
    }
  }

  refreshData(target: number): void {
    let action$: Observable<Thumbnail[] | Artist[] | Style[] | never> = EMPTY;

    if(target === 1) {
      action$ = this.thumbnailsService.getUnusedThumbnails();
      this.selectedThumbnail.set(undefined);
      this.allUnusedThumbnails.set([]);
      this.thumbnailForm.controls['selectedThumbnail'].setValue(null);
    } else if(target === 2) {
      action$ = this.artistService.getAll<Artist>();
      this.selectedArtist.set(undefined);
      this.allArtists.set([]);
      this.artistForm.controls['selectedArtist'].setValue(null);
    } else if(target === 3) {
      action$ = this.stylesService.getAll<Style>();
      this.selectedStyle.set(undefined);
      this.allStyles.set([]);
      this.styleForm.controls['selectedStyle'].setValue(null);
    }

    if(action$) {
      action$.subscribe({
        next: (data: Thumbnail[] | Artist[] | Style[]) => {
          if(target === 1) {
            this.allUnusedThumbnails.set(data as Thumbnail[]);
          } else if(target === 2) {
            this.allArtists.set(data as Artist[]);
          } else if(target === 3) {
            this.allStyles.set(data as Style[]);
          }
        },
        error: () => {
          this.toastr.error('Can\'t refresh data.');
        }
      });
    }
  }

  private getData(id?: number): void {
    const actions$ = {
      artists: this.artistService.getAll<Artist>(),
      styles: this.stylesService.getAll<Style>(),
      unusedThumbnails: this.thumbnailsService.getUnusedThumbnails(),
      painting: id ? this.paintingsService.getDetailsWithThumbnail(id) : of(undefined)    
    };

    forkJoin(actions$).subscribe({
      next: (data) => {
        this.allArtists.set(data.artists);
        this.allStyles.set(data.styles);
        this.allUnusedThumbnails.set(data.unusedThumbnails);

        if(data.painting) {
          this._updatePainting.set(data.painting);
        }
      },
      error: () => {
        this.toastr.error('Can\'t fetch all necessary data');
      },
      complete: () => {
        if(this._updatePainting()) {
          this.paintingForm.patchValue(this._updatePainting()!);

          if(this._updatePainting()?.artist) {
            this.artistForm.controls['selectedArtist'].setValue(this._updatePainting()!.artist);
            this.selectedArtist.set(this._updatePainting()!.artist);
          }

          if(this._updatePainting()?.style) {
            this.styleForm.controls['selectedStyle'].setValue(this._updatePainting()!.style);
            this.selectedStyle.set(this._updatePainting()!.style);
          }

          if(this._updatePainting()?.thumbnail) {            
            this.thumbnailForm.controls['selectedThumbnail'].setValue(this._updatePainting()!.thumbnail);
            this.selectedThumbnail.set(this._updatePainting()!.thumbnail);
          }
        }

        this.isLoaded.set(true);
      }
    });
  }

  private assignValues(): Painting {
    const painting: Painting = Object.assign(this.paintingForm.value);

    if(this.isUpdateMode() && this._updatePainting()) {
      painting.id = this._updatePainting()!.id;
    }

    painting.artist = this.selectedArtist();
    painting.style = this.selectedStyle();
    painting.thumbnail = this.selectedThumbnail();

    return painting;
  }

}