import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor(private _http: HttpClient,
    private _router: Router) { }

  public login(username: string, password: string): Observable<any> {
    return this._http.get(`/api/Token/GetTokenBasedonCredentials?UserName=${username}&Password=${password}`);
  }

  public getToken(): string {
    return localStorage.getItem('authToken');
  }

  public setToken(token: string): void {
    localStorage.setItem('authToken', token);
  }

  public getUsername(): string {
    return localStorage.getItem('username');
  }

  public setUsername(username: string): void {
    localStorage.setItem('username', username);
  }

  public getOrganizationId(): string {
    return localStorage.getItem('organizationId');
  }

  public setOrganizationId(organizationId: number): void {
    localStorage.setItem('organizationId', organizationId.toString());
  }

  public getRoleId(): string {
    return localStorage.getItem('roleId');
  }

  public setRoleId(roleId: number): void {
    localStorage.setItem('roleId', roleId.toString());
  }


  public logout(): void {
    localStorage.removeItem('authToken');
    localStorage.removeItem('username');
    this._router.navigate(['login']);
  }

}
