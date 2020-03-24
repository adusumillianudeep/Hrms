import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { MyLeaveUsageComponent } from './my-leave-usage.component';

const routes: Routes = [
  {
    path: '**',
    component: MyLeaveUsageComponent
  }
];

@NgModule({
  declarations: [MyLeaveUsageComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class MyLeaveUsageModule { }
