import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { LeaveUsageComponent } from './leave-usage.component';

const routes: Routes = [
  {
    path: '**',
    component: LeaveUsageComponent
  }
];

@NgModule({
  declarations: [LeaveUsageComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class LeaveUsageModule { }
