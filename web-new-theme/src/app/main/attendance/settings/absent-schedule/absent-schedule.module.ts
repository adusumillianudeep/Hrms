import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';

import { AbsentScheduleComponent } from './absent-schedule.component';

const routes: Routes = [
  {
    path: '**',
    component: AbsentScheduleComponent
  }
];


@NgModule({
  declarations: [AbsentScheduleComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class AbsentScheduleModule { }
