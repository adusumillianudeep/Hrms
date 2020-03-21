import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { WorkWeekComponent } from './work-week.component';

const routes: Routes = [
  {
    path: '**',
    component: WorkWeekComponent
  }
];

@NgModule({
  declarations: [WorkWeekComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class WorkWeekModule { }
