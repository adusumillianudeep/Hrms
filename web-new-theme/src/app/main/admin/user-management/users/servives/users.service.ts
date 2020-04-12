import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../models/user';
import { Roles } from '../models/roles';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  constructor(private _http: HttpClient) { }

  public getUsers(): Observable<any> {
    return this._http.get('/api/user/get')
  }

  public saveUser(user: User): Observable<any> {
    return this._http.post('/api/user/InsertUserDetails', user);

  }
  public getRoles(): Observable<any> {
    return this._http.get('/api/user/GetRoles');
  }

  public onSearchChange(searchText: string): Observable<any> {
    let params = new HttpParams();
    params = params.append('SearchText', searchText);
    return this._http.get('/api/user/GetEmployeesBySearch', { params: params });
  }
}