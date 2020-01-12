import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { OrganizationRoutingModule } from "./organization/organization-routing.module";

const Adminroute: Routes = [];

@NgModule({
    imports: [OrganizationRoutingModule],
    exports: [RouterModule]
  })
  export class AdminRoutingModule { }