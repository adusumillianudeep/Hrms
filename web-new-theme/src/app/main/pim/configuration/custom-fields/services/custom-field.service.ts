import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CustomFieldService {

  constructor(private _http: HttpClient) { }

  public saveTitle(customSection: any): Observable<any> {
    return this._http.post('/api/customfields/SaveTitle', customSection);
  }

  public getCustomSections(): Observable<any> {
    return this._http.get('/api/wizard/GetCustomSections');
  }
}
