import { signalStore, withState, withMethods, patchState } from '@ngrx/signals';
import { Pagination } from '../models/store/pagination.interface';

export const initialState: Pagination = {
    pageIndex: 0,
    pagerSize: 25
};

export const PaginationStore = signalStore(
    { providedIn: 'root' },
    withState(initialState),
    withMethods((store) => ({
        updatePageIndex: (index: number) => {
             patchState(store, { pageIndex: index });
        },
        updatePageSize: (size: number) => {
            patchState(store, { pagerSize: size });
        },
        reset: () => {
            patchState(store, initialState);
        }
    }))
);