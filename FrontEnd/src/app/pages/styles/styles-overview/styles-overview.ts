import { Component, inject, OnInit, WritableSignal, signal } from '@angular/core';
import { AllMatModules } from '../../../all-mat-modules.module';
import { RouterLink } from '@angular/router';
import { Style } from '../../../models/style/style.interface';
import { Styles } from '../../../services/style/styles';
import { Shared } from '../../../shared_methods/shared';

@Component({
  selector: 'app-styles-overview',
  imports: [AllMatModules, RouterLink],
  templateUrl: './styles-overview.html',
  styleUrl: './styles-overview.scss',
})
export class StylesOverview extends Shared<Style> implements OnInit {
  protected displayedColumns: WritableSignal<string[]> = signal(['name', 'actions']);

  private stylesService = inject(Styles);

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
        this.toastr.show('Can\'t fetch all Styles.', 'error');
      },
    });
  }
}