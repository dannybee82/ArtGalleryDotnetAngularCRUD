import { inject } from "@angular/core";
import { Router } from "@angular/router";
import { Observer, Subject } from "rxjs";
import { ObserverMessages } from "../models/shared/observer.messages.interface";
import { ToastService } from "../services/toast/toast-service";

export class SharedObserver {

    private _refresh: Subject<boolean> = new Subject<boolean>();

    private toastr = inject(ToastService);
    private router = inject(Router);

    getObserverSimple(messages: ObserverMessages, redirects?: string[]):  Observer<void> {
        const observer: Observer<void> = {
            next: () => {
                this.toastr.show(messages.createSucces, 'success');
            },
            error: () => {
                this.toastr.show(messages.createError, 'error');
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
                this.toastr.show(isUpdate ? messages.updateSuccess: messages.createSucces, 'success');
            },
            error: () => {
                this.toastr.show(isUpdate ? messages.updateError : messages.createError, 'error');
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