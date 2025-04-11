import { Routes } from '@angular/router';
import { AllPaintingsComponent } from './pages/all-paintings/all-paintings.component';
import { PaintingDetailsComponent } from './pages/painting-details/painting-details.component';
import { MenuComponent } from './components/menu/menu.component';
import { UploadImageComponent } from './pages/upload-image/upload-image.component';
import { CreatePaintingComponent } from './pages/create-painting/create-painting.component';
import { ArtistsOverviewComponent } from './pages/artists/artists-overview/artists-overview.component';
import { CreateOrUpdateArtistComponent } from './pages/artists/create-or-update-artist/create-or-update-artist.component';
import { StylesOverviewComponent } from './pages/styles/styles-overview/styles-overview.component';
import { CreateOrUpdateStyleComponent } from './pages/styles/create-or-update-style/create-or-update-style.component';

export const routes: Routes = [
    {
        path: '',
        component: MenuComponent,
        children: [
            {
                path: '',
                component: AllPaintingsComponent
            },
            {
                path: 'painting-details/:id',
                component: PaintingDetailsComponent
            },
            {
                path: 'upload-images',
                component: UploadImageComponent
            },
            {
                path: 'create-or-update-painting/:id',
                component: CreatePaintingComponent
            },
            {
                path: 'create-or-update-painting',
                component: CreatePaintingComponent
            },
            {
                path: 'all-artists',
                component: ArtistsOverviewComponent
            },
            {
                path: 'create-or-update-artist',
                component: CreateOrUpdateArtistComponent
            },
            {
                path: 'create-or-update-artist/:id',
                component: CreateOrUpdateArtistComponent
            },
            {
                path: 'all-styles',
                component: StylesOverviewComponent
            },
            {
                path: 'create-or-update-style',
                component: CreateOrUpdateStyleComponent
            },
            {
                path: 'create-or-update-style/:id',
                component: CreateOrUpdateStyleComponent
            }
        ]
    }    
];
