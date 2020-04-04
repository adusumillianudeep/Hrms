import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { PersonalDetailsComponent } from '../components/personal-details/personal-details.component';
import { JobProfilesComponent } from '../components/job-profiles/job-profiles.component';
import { MoreInfoComponent } from '../components/more-info/more-info.component';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private _http: HttpClient) { }

  public getConfiguration(): Observable<any> {
    return this._http.get('/api/wizard/GetConfiguration');
  }

  public getSectionComponentMapping() {
    const sections = [
      {
        name: 'personal details',
        component: PersonalDetailsComponent
      },
      {
        name: 'job',
        component: JobProfilesComponent
      },
      {
        name: 'more info',
        component: MoreInfoComponent
      }
    ]

    return sections;
  }
}
