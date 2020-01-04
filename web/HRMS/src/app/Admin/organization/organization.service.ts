import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class OrganizationService {
    constructor(private http: HttpClient) { }

    configUrl = 'http://localhost:57960/api/';
    GetGeneralInfo() {
        return this.http.get(this.configUrl + 'GeneralInfo/GetGeneralInfo')
    }
}