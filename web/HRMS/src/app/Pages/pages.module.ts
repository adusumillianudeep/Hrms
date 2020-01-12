import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PagesComponent } from './pages.component';
import { AdminModule } from "./Admin/admin.module";
import { LayoutModule } from "../Shared/layout.module";
import { RouterModule } from '@angular/router';


@NgModule({
  declarations: [PagesComponent],
  imports: [
    CommonModule,
    AdminModule,
    LayoutModule,
    RouterModule
  ],
  bootstrap:[PagesComponent]
})
export class PagesModule { }
