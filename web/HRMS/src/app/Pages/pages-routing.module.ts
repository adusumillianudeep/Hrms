import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminRoutingModule } from "./Admin/admin-routing.module";
import { PagesComponent } from "./pages.component";

const Pageroute: Routes = [
  {
    path: 'pages',
    component: PagesComponent,
    children: [
      { path: '', redirectTo: 'index', pathMatch: 'full' },
      { path: 'organization', loadChildren: './Admin/organization/organization.module#OrganizationModule' }
    ]
  }
  
];

@NgModule({
    imports: [AdminRoutingModule,RouterModule.forChild(Pageroute)],
    exports: [RouterModule]
  })

  export class PagesRoutingModule { }