import { Component, OnInit, WritableSignal, inject, signal } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, UntypedFormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { catchError, EMPTY, map, Observable, switchMap } from 'rxjs';
import { ToastrService } from 'ngx-toastr';
import { AllMatModules } from '../../../all-mat-modules.module';
import { Style } from '../../../models/style/style.interface';
import { StylesService } from '../../../services/style/styles.service';
import { ObserverMessages } from '../../../models/shared/observer.messages.interface';
import { SharedObserver } from '../../../shared_methods/shared.observer';
import { RouterLink } from '@angular/router';
import { DeleteDialogData } from '../../../models/dialogs/delete-dialog-data.interface';
import { DeleteDialogComponent } from '../../../components/delete-dialog/delete-dialog.component';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-create-or-update-style',
  imports: [
    FormsModule,
    ReactiveFormsModule,
    AllMatModules,
    RouterLink
  ],
  templateUrl: './create-or-update-style.component.html',
  styleUrl: './create-or-update-style.component.scss'
})
export class CreateOrUpdateStyleComponent implements OnInit {

  isUpdateMode: WritableSignal<boolean> = signal(false);
  private _updateStyle: WritableSignal<Style | undefined> = signal(undefined);

  StyleForm: UntypedFormGroup = new FormGroup({});

  private _sharedObserver: SharedObserver = new SharedObserver();

  private fb = inject(FormBuilder);
  private activeRoute = inject(ActivatedRoute);
  private router = inject(Router);
	private toastr = inject(ToastrService);
  private styleService = inject(StylesService);
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

    this.StyleForm = this.fb.group({
      name: ['', Validators.required],
      description: ['', Validators.required]
    });
  }

  submit(): void {
    if(this.StyleForm.valid) {
      const style: Style = Object.assign(this.StyleForm.value);

      if(this.isUpdateMode() && this._updateStyle()) {
        style.id = this._updateStyle()!.id;
      }

      const action$: Observable<void> = this.isUpdateMode() ?
        this.styleService.update(style): 
        this.styleService.create(style);

      const messages: ObserverMessages = {
        createSucces: 'Style successfully created',
        createError: 'Can\'t create Style',
        updateSuccess: 'Style successfully updated',
        updateError: 'Can\'t update Style'
      };

      action$.subscribe(this._sharedObserver.getObserver(this.isUpdateMode(), messages, ['/all-styles']));
    } else {
      this.StyleForm.markAllAsTouched();
      this.toastr.error('Form invalid.');
    }
  }

  deleteStyle(): void {
    if(this._updateStyle()) {
      const dialogData: DeleteDialogData = {
        title: 'Delete Style',
        message: 'Do you want to the delete the Style below?',
        additionalData: `${this._updateStyle()?.name}`,
        confirmDelete: false
      };
  
      const dialog = this.dialog.open(DeleteDialogComponent, {data: dialogData});
    
      const result$: Observable<void> = dialog.afterClosed().pipe(
        switchMap((data: DeleteDialogData) => {
          if(data) {
            if(data.confirmDelete) {
              return this.styleService.delete<Style>(this._updateStyle()?.id ?? 0); 
            }            
          }
              
          return EMPTY;
        })
      );
          
      result$.subscribe({
        next: () => {
          this.toastr.success('Style successfully deleted');
          this.router.navigate(['/']);
        },
        error: () => {
          this.toastr.error('Can\'t delete Style');
        }
      });      
    } else {
      this.toastr.error('There is no Style loaded.');
    }
  }

  private getData(id: number): void {
    this.styleService.getById<Style>(id).subscribe({
      next: (data: Style) => {
        this._updateStyle.set(data);
      },
      error: () => {
        this.toastr.error('Can\'t fetch Style Details');
      },
      complete: () => {
        if(this._updateStyle()) {
          this.StyleForm.patchValue(this._updateStyle()!);
        }
      }
    });
  }

}