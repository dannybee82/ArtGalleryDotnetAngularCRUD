import { FilterItem } from "./filter-item.interface";

export interface FiltersAvailable {
	styles: FilterItem[],
	artists: FilterItem[],
	years: FilterItem[]
}
