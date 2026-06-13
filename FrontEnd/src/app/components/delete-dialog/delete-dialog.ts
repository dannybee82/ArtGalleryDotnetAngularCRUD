import { Component, inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { DeleteDialogData } from '../../models/dialogs/delete-dialog-data.interface';

@Component({
  selector: 'app-delete-dialog',
  templateUrl: './delete-dialog.html',
  styleUrls: ['./delete-dialog.scss'],
  imports: [MatIconModule, MatButtonModule],
})
export class DeleteDialog {
  public dialogRef = inject(MatDialogRef<DeleteDialog>);
  public data: DeleteDialogData = inject(MAT_DIALOG_DATA);

  onCancel(): void {
    this.data.confirmDelete = false;
    this.dialogRef.close(this.data);
  }

  onDelete(): void {
    this.data.confirmDelete = true;
    this.dialogRef.close(this.data);
  }
}