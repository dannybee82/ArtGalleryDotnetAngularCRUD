import { signalStore, withState, withMethods, patchState } from '@ngrx/signals';
import { CurrentFilter } from '../models/store/current-filter.interface';

export const initialState: CurrentFilter = {
    filterOn: false,
    currentFilters: undefined
};

export const FilterStore = signalStore(
        { providedIn: 'root' },
        withState(initialState),
        withMethods((store) => ({
            update: (data: CurrentFilter) => {
                patchState(store, {...data});
            },
            reset: () => {
                patchState(store, {...initialState});
            }
        }))
);