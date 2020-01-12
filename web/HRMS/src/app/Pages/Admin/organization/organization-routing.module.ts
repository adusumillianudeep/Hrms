import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GeneralInfoComponent } from './general-info/general-info.component';
import { LocationComponent } from './location/location.component';


const organizationroute: Routes = [
  { path: '', redirectTo: 'organization-generalinfo', pathMatch: 'full' },
  { path: 'organization-generalinfo', component: GeneralInfoComponent },
  { path: 'organization-locationinfo', component: LocationComponent }
];

@NgModule({
  imports: [RouterModule.forChild(organizationroute)],
  exports: [RouterModule]
})
export class OrganizationRoutingModule { }
