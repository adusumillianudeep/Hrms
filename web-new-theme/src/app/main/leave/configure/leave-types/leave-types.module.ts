import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { LeaveTypesComponent } from './leave-types.component';

const routes: Routes = [
  {
    path: '**',
    component: LeaveTypesComponent
  }
];

@NgModule({
  declarations: [LeaveTypesComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class LeaveTypesModule { }
