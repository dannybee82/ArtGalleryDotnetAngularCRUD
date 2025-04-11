import { Observable } from "rxjs";

export interface IApiService<T> {

    getAll() : Observable<T[]>

    getAllById(id: number) : Observable<T[]>

    getById(id: number) : Observable<T>

    create(entity: T) : Observable<void>

    update(entity: T) : Observable<void>

    delete(id: number) : Observable<void>

}