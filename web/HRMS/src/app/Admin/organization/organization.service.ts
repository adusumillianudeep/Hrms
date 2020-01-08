import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class OrganizationService {
    configUrl = 'http://localhost:57960/api';
    constructor(private http: HttpClient) { 
        debugger;
        this.http.get('assets/config.json').subscribe(data=>{
            debugger;
            this.configUrl = data["api"]["apiUrl"]
        })
    }

    
    getGeneralInfo(id) {
        return this.http.get(`${this.configUrl}/GeneralInfo/GetGeneralInfo/${id}`);
    }

    saveGeneralInfo(body) {
        return this.http.post(`${this.configUrl}/GeneralInfo/SaveGeneralInfo`, body);
    }

    saveLocationInfo(body) {
        return this.http.post(`${this.configUrl}/GeneralInfo/SaveLocationInfo`, body);
    }
}
