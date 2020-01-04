import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminRoutingModule } from "./Admin/admin-routing.module";

const routes: Routes = [];

@NgModule({
  imports: [RouterModule.forRoot(routes),AdminRoutingModule],
  exports: [RouterModule]
})
export class AppRoutingModule { }
