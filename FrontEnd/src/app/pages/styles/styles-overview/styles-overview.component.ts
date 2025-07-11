import { Component, inject, OnInit, WritableSignal, signal } from '@angular/core';
import { AllMatModules } from '../../../all-mat-modules.module';
import { RouterLink } from '@angular/router';
import { Style } from '../../../models/style/style.interface';
import { StylesService } from '../../../services/style/styles.service';
import { SharedComponent } from '../../../shared_methods/shared.component';

@Component({
  selector: 'app-styles-overview',
  imports: [
    AllMatModules,
    RouterLink
  ],
  templateUrl: './styles-overview.component.html',
  styleUrl: './styles-overview.component.scss'
})
export class StylesOverviewComponent extends SharedComponent<Style> implements OnInit {

  protected displayedColumns: WritableSignal<string[]> = signal(['name', 'actions']);

  private stylesService = inject(StylesService);

  constructor() {
    super();
  }

  ngOnInit(): void {
    this.stylesService.getAll<Style>().subscribe({
      next: (data: Style[]) => {
        this.total.set(data.length); 
        this.dataSource.data = data;
        this.dataSource.paginator = this.paginator();
      },
      error: () => {
        this.toastr.error('Can\'t fetch all Styles.');
      }
    });
  }

}