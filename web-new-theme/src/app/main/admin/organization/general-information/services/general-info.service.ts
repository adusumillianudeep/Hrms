import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { GeneralInformation } from '../models/general-information';
import { AuthenticationService } from 'app/main/login/services/authentication.service';

@Injectable({
  providedIn: 'root'
})
export class GeneralInfoService {

  constructor(private _http: HttpClient,
    private _authService: AuthenticationService
  ) { }

  getData(): Observable<GeneralInformation> {
    const organizationId = +this._authService.getOrganizationId();
    return this._http.get<GeneralInformation>(`/api/GeneralInfo/GetGeneralInfo/${organizationId}`);
  }

  save(generalInfo: GeneralInformation): Observable<any> {
    return this._http.post('/api/GeneralInfo/SaveGeneralInfo', generalInfo);
  }
}
