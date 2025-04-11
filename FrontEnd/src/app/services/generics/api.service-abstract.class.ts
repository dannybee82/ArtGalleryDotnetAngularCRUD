import { Observable } from "rxjs";
import { IApiService } from "./api-service-interface";
import { HttpParams } from "@angular/common/http";
import { environment } from "../../../environments/environment";
import { ApiModel } from "./api-model.interface";

export abstract class ApiServiceAbstract<T> implements IApiService<T> {

    private _endPoint: string = environment.endpoint;

    constructor(
        protected api: ApiModel
    ) {}

    getAll<T>(): Observable<T[]> {
        if(this.api.getAllFunction === '') {
            throw new Error('Function not implemented');
        }

        return this.api.http.get<T[]>(this._endPoint + this.api.controllerName + '/' + this.api.getAllFunction);
    }

    getAllById<T>(id: number): Observable<T[]> {
        if(this.api.getAllByIdFunction === '') {
            throw new Error('Function not implemented');
        }

        const params: HttpParams = new HttpParams().append(this.api.getAllByIdQueryParam, id);
        return this.api.http.get<T[]>(this._endPoint + this.api.controllerName + '/' + this.api.getAllByIdFunction, {params});
    }

    getById<T>(id: number): Observable<T> {
        if(this.api.getByIdFunction === '') {
            throw new Error('Function not implemented');
        }

        const params: HttpParams = new HttpParams().append(this.api.getByIdQueryParam, id);
        return this.api.http.get<T>(this._endPoint + this.api.controllerName + '/' + this.api.getByIdFunction, {params});
    }

    create<T>(entity: T): Observable<void> {
        if(this.api.createFunction === '') {
            throw new Error('Function not implemented');
        }

        return this.api.http.post<void>(this._endPoint + this.api.controllerName + '/' + this.api.createFunction, entity);
    }

    update<T>(entity: T): Observable<void> {
        if(this.api.updateFunction === '') {
            throw new Error('Function not implemented');
        }

        return this.api.http.put<void>(this._endPoint + this.api.controllerName + '/' + this.api.updateFunction, entity);
    }

    delete<T>(id: number): Observable<void> {
        if(this.api.deleteFunction === '') {
            throw new Error('Function not implemented');
        }

        const params: HttpParams = new HttpParams().append(this.api.deleteQueryParam, id);
        return this.api.http.delete<void>(this._endPoint + this.api.controllerName + '/' + this.api.deleteFunction, {params});
    }

}