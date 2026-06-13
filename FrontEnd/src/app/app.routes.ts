import { Routes } from '@angular/router';
import { AllPaintings } from './pages/all-paintings/all-paintings';
import { PaintingDetails } from './pages/painting-details/painting-details';
import { Menu } from './components/menu/menu';
import { UploadImage } from './pages/upload-image/upload-image';
import { CreatePainting } from './pages/create-painting/create-painting';
import { ArtistsOverview } from './pages/artists/artists-overview/artists-overview';
import { CreateOrUpdateArtist } from './pages/artists/create-or-update-artist/create-or-update-artist';
import { StylesOverview } from './pages/styles/styles-overview/styles-overview';
import { CreateOrUpdateStyle } from './pages/styles/create-or-update-style/create-or-update-style';

export const routes: Routes = [
    {
        path: '',
        component: Menu,
        children: [
            {
                path: '',
                component: AllPaintings
            },
            {
                path: 'painting-details/:id',
                component: PaintingDetails
            },
            {
                path: 'upload-image',
                component: UploadImage
            },
            {
                path: 'create-or-update-painting/:id',
                component: CreatePainting
            },
            {
                path: 'create-or-update-painting',
                component: CreatePainting
            },
            {
                path: 'all-artists',
                component: ArtistsOverview
            },
            {
                path: 'create-or-update-artist',
                component: CreateOrUpdateArtist
            },
            {
                path: 'create-or-update-artist/:id',
                component: CreateOrUpdateArtist
            },
            {
                path: 'all-styles',
                component: StylesOverview
            },
            {
                path: 'create-or-update-style',
                component: CreateOrUpdateStyle
            },
            {
                path: 'create-or-update-style/:id',
                component: CreateOrUpdateStyle
            }
        ]
    }    
];
