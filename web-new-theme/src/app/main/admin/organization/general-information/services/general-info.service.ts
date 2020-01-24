import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { GeneralInformation } from '../models/general-information';

@Injectable({
  providedIn: 'root'
})
export class GeneralInfoService {

  constructor(private _http: HttpClient) { }

  getData(): Observable<GeneralInformation> {
    return this._http.get<GeneralInformation>('/api/GeneralInfo/GetGeneralInfo/1');
  }

  save(generalInfo: GeneralInformation): Observable<any> {
    return this._http.post('/api/GeneralInfo/SaveGeneralInfo', generalInfo);
  }
}
