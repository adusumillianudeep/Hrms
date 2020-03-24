import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { LeavePeriodComponent } from './leave-period.component';

const routes: Routes = [
  {
    path: '**',
    component: LeavePeriodComponent
  }
];

@NgModule({
  declarations: [LeavePeriodComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class LeavePeriodModule { }
