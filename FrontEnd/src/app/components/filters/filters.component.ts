import { Component, inject, OnInit, output, OutputEmitterRef, signal, WritableSignal } from '@angular/core';
import { AvailableFilterService } from '../../services/filters/available-filter.service';
import { FiltersAvailable } from '../../models/filters/filters-available.interface';
import { FilterItem } from '../../models/filters/filter-item.interface';
import { FilterData } from '../../models/filters/filter-data.interface';
import { ToastrService } from 'ngx-toastr';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, UntypedFormGroup } from '@angular/forms';
import { AllMatModules } from '../../all-mat-modules.module';

@Component({
  selector: 'app-filters',
  imports: [
    AllMatModules,
    FormsModule,
    ReactiveFormsModule,
  ],
  templateUrl: './filters.component.html',
  styleUrl: './filters.component.scss'
})
export class FiltersComponent implements OnInit {

  protected filterStyles: WritableSignal<FilterItem[]> = signal([]);
  protected filterArtists: WritableSignal<FilterItem[]> = signal([]);
  protected filterYears: WritableSignal<FilterItem[]> = signal([]);
  protected currentFilters: WritableSignal<FilterData> = signal({});
  protected isFilterOn: WritableSignal<boolean> = signal(false);

  filterForm: UntypedFormGroup = new FormGroup({});

  readonly filterValues: OutputEmitterRef<FilterData | undefined> = output<FilterData | undefined>();

  private availableFilterService = inject(AvailableFilterService);
  private toastr = inject(ToastrService);
  private fb = inject(FormBuilder);

  ngOnInit(): void {
    this.filterForm = this.fb.group({
      styles: [],
      artists: [],
      years: []
    });

    this.filterForm.valueChanges.subscribe(() => {
      this.filter();
    });

    this.getAvaiableFilters();
  }

  getActiveFilters(): FilterItem[] {
    let arr: FilterItem[] = [];

    const controlNames: string[] = ['styles', 'artists', 'years'];
    const targetArrs: FilterItem[][] = [this.filterStyles(), this.filterArtists(), this.filterYears()];
    const categories: string[] = ['Style', 'Artist', 'Year'];

    for(let i = 0; i < controlNames.length; i++) {
      const values: number[] | undefined = this.filterForm.controls[controlNames[i]].value;
    
      if(values) {
        for(let j = 0; j < values.length; j++) {
          const itemfound: FilterItem | undefined = structuredClone(targetArrs[i]).find(item => item.value === values[j]);

          if(itemfound) {
            itemfound.category = categories[i];
            itemfound.controlname = controlNames[i];
            arr.push(itemfound);
          }          
        }
      }
    }

    return arr;
  }

  removeFilter(category: string, value: number): void {
    const filterData: FilterData = this.getCurrentFilters();

    const keys: string[] = Object.keys(filterData);

    const index: number = keys.indexOf(category);

    if(index > -1) {
      const property = keys[index] as keyof typeof filterData;
      const targetValues: (number[]) | undefined = filterData[property];
      
      if(targetValues) { 
        if(Array.isArray(targetValues)) { 
          let arr: number[] = (targetValues as number[]).filter(item => item !== value);
          filterData[property] = arr.length === 0 ? undefined : arr;
        } else {
          filterData[property] = undefined;
        }
      }

      if(filterData.styles || filterData.artists || filterData.years) {
        this.filterForm.patchValue(filterData);
        this.filter();
      } else {
        this.reset();
      }
    }
  }

  reset(): void {
    this.filterForm.reset();
    this.isFilterOn.set(false);
    this.filterValues.emit(undefined);    
  }

  private getAvaiableFilters(): void {
    this.filterStyles.set([]);
    this.filterArtists.set([]);
    this.filterYears.set([]);

    this.availableFilterService.getAvailableFilters(this.currentFilters()).subscribe({
      next: (data: FiltersAvailable) => {
        this.filterStyles.set(data.styles);
        this.filterArtists.set(data.artists);
        this.filterYears.set(data.years);
      },
      error: () => {
        this.toastr.error('Can\'t fetch Filters');
      }
    });
  }

  private filter(): void {
    const filterData: FilterData = this.getCurrentFilters();

    if(filterData.styles || filterData.artists || filterData.years) {
      this.isFilterOn.set(true);
      this.filterValues.emit(filterData);
      this.currentFilters.set(filterData);
    } else {
      this.isFilterOn.set(false);
      this.filterValues.emit(undefined);
      this.currentFilters.set({});
    }

    this.getAvaiableFilters();
  }

  private getCurrentFilters() : FilterData {
    const filterData: FilterData = Object.assign(this.filterForm.value);

    if(!filterData.styles) {
      delete filterData.styles;      
    }

    if(!filterData.artists) {
      delete filterData.artists;      
    }

    if(!filterData.years) {
      delete filterData.years;      
    }

    return filterData;
  }

}