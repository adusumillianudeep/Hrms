import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ConfigurationnService {

  constructor(private _http: HttpClient) { }

  public get(): Observable<any> {
    return this._http.get('/api/wizard/GetConfiguration');
  }

  public save(config: any): Observable<any> {
    return this._http.post('/api/wizard/SaveConfiguration', config);
  }

}
