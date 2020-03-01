import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeDataExportComponent } from './employee-data-export.component';
import { Routes, RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';

const routes: Routes = [
  {
    path: '**',
    component: EmployeeDataExportComponent
  }
];
@NgModule({
  declarations: [EmployeeDataExportComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class EmployeeDataExportModule { }
