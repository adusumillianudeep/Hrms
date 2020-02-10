import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { WorkShiftsComponent } from './work-shifts.component';
import { Routes, RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';

const routes: Routes = [
  {
    path: '**',
    component: WorkShiftsComponent
  }
];

@NgModule({
  declarations: [WorkShiftsComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class WorkShiftsModule { }
