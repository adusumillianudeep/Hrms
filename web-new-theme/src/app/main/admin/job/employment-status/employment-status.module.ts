import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmploymentStatusComponent } from './employment-status.component';
import { Routes, RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';

const routes: Routes = [
  {
    path: '**',
    component: EmploymentStatusComponent
  }
];

@NgModule({
  declarations: [EmploymentStatusComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes),
  ]
})
export class EmploymentStatusModule { }
