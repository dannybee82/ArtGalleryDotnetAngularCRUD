import { HttpClient } from "@angular/common/http";

export interface ApiModel {
    http: HttpClient,
    controllerName: string,
    getAllFunction: string,
    getAllByIdFunction: string,
    getAllByIdQueryParam: string,
    getByIdFunction: string,
    getByIdQueryParam: string,
    createFunction: string,
    updateFunction: string,
    deleteFunction: string,
    deleteQueryParam: string,
}