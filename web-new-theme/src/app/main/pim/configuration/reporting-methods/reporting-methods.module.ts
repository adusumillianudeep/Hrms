import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReportingMethodsComponent } from './reporting-methods.component';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '**',
    component: ReportingMethodsComponent
  }
];

@NgModule({
  declarations: [ReportingMethodsComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class ReportingMethodsModule { }
