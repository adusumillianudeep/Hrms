import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GeneralInfoComponent } from "./general-info/general-info.component";


const organizationroute: Routes = [{path:"organization-generalinfo",component:GeneralInfoComponent}];

@NgModule({
    imports: [RouterModule.forChild(organizationroute)],
    exports: [RouterModule]
  })
  export class OrganizationRoutingModule { }