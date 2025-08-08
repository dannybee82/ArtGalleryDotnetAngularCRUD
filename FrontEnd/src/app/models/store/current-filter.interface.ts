import { FilterData } from "../filters/filter-data.interface";

export interface CurrentFilter {
    filterOn: boolean,
    currentFilters: FilterData | undefined
}