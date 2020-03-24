import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { LeaveListComponent } from './leave-list.component';

const routes: Routes = [
  {
    path: '**',
    component: LeaveListComponent
  }
];

@NgModule({
  declarations: [LeaveListComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class LeaveListModule { }
