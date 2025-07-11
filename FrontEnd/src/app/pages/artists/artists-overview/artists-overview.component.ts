import { AfterViewInit, Component, inject, OnInit, signal, Signal, viewChild, WritableSignal } from '@angular/core';
import { AllMatModules } from '../../../all-mat-modules.module';
import { Artist } from '../../../models/artist/artist.interface';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { ArtistsService } from '../../../services/artists/artists.service';
import { ToastrService } from 'ngx-toastr';
import { RouterLink } from '@angular/router';
import { SharedComponent } from '../../../shared_methods/shared.component';

@Component({
  selector: 'app-artists-overview',
  imports: [
    AllMatModules,
    RouterLink
  ],
  templateUrl: './artists-overview.component.html',
  styleUrl: './artists-overview.component.scss'
})
export class ArtistsOverviewComponent extends SharedComponent<Artist> implements OnInit {

  protected isLoaded: WritableSignal<boolean> = signal(false);
  protected displayedColumns: WritableSignal<string[]> = signal(['name', 'years', 'actions']);
  
  private artistsService = inject(ArtistsService);

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
        this.toastr.error('Can\'t fetch all Artists.');
      },
      complete: () => {
        this.isLoaded.set(true);
      }
    });
  }

}