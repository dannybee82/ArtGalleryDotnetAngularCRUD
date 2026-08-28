import { Component, inject, OnInit, signal, WritableSignal } from '@angular/core';
import { AllMatModules } from '../../../all-mat-modules.module';
import { Artist } from '../../../models/artist/artist.interface';
import { Artists } from '../../../services/artists/artists';
import { RouterLink } from '@angular/router';
import { Shared } from '../../../shared_methods/shared';

@Component({
  selector: 'app-artists-overview',
  imports: [AllMatModules, RouterLink],
  templateUrl: './artists-overview.html',
  styleUrl: './artists-overview.scss',
})
export class ArtistsOverview extends Shared<Artist> implements OnInit {
  protected isLoaded: WritableSignal<boolean> = signal(false);
  protected displayedColumns: WritableSignal<string[]> = signal(['name', 'years', 'actions']);

  private artistsService = inject(Artists);

  constructor() {
    super();
  }

  ngOnInit(): void {
    this.artistsService.getAll<Artist>().subscribe({
      next: (data: Artist[]) => {
        this.total.set(data.length);
        this.dataSource.data = data;
        this.dataSource.paginator = this.paginator();
      },
      error: () => {
        this.toastr.show('Can\'t fetch all Artists.', 'error');
      },
      complete: () => {
        this.isLoaded.set(true);
      },
    });
  }
}