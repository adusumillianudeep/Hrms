import { Injectable } from '@angular/core';
import {
    HttpRequest,
    HttpHandler,
    HttpEvent,
    HttpInterceptor,
    HttpResponse
} from '@angular/common/http';
import { AuthenticationService } from 'app/main/login/services/authentication.service';
import { environment } from 'environments/environment';
import { throwError as observableThrowError, Observable, BehaviorSubject } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable()
export class HttpRequestInterceptor implements HttpInterceptor {


    constructor(public auth: AuthenticationService) {
    }
    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        const endPoint = request.url;
        const baseUrl = environment.baseURL;
        if (this.auth.getToken()) {
            request = request.clone({
                setHeaders: {
                    Authorization: `Bearer ${this.auth.getToken()}`,
                    url: `${baseUrl}${endPoint}`
                }
            });
        } else {
            request = request.clone({ url: `${baseUrl}${endPoint}` });
        }
        return next.handle(request).pipe(catchError(err => {
            // check if err status is 401 unathroried if yes redirect to login      
            if (err.status === 401 || err.status === 400 || err.statusText === 'Unauthorized') {
                // this.auth.logout();
            }
            else {
                // this.alertService.error(err.error.exceptionMessage);
            }
            return observableThrowError(err);
        }));
    }
}