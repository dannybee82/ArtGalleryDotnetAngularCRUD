import { inject } from "@angular/core";
import { Router } from "@angular/router";
import { ToastrService } from "ngx-toastr";
import { Observer, Subject } from "rxjs";
import { ObserverMessages } from "../models/shared/observer.messages.interface";

export class SharedObserver {

    private _refresh: Subject<boolean> = new Subject<boolean>();

    private toastr = inject(ToastrService);
    private router = inject(Router);

    getObserverSimple(messages: ObserverMessages, redirects?: string[]):  Observer<void> {
        const observer: Observer<void> = {
            next: () => {
                this.toastr.success(messages.createSucces);
            },
            error: () => {
                this.toastr.error(messages.createError);
            },
            complete: () => {
                this._refresh.next(true);

                if(redirects) {
                    setTimeout(() => {
                        this.router.navigate(redirects);
                    }, 500);                   
                }
            }
        }

        return observer;
    }

    getObserver(isUpdate: boolean, messages: ObserverMessages, redirects?: string[]) : Observer<void> {
        const observer: Observer<void> = {
            next: () => {
                this.toastr.success(isUpdate ? messages.updateSuccess: messages.createSucces);
            },
            error: () => {
                this.toastr.error(isUpdate ? messages.updateError : messages.createError);
            },
            complete: () => {
                this._refresh.next(true);

                if(redirects) {
                    setTimeout(() => {
                        this.router.navigate(redirects);
                    }, 500);                   
                }
            }
        }

        return observer;
    }

    getRefresh(): Subject<boolean> {
        return this._refresh;
    }

}