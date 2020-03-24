import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { MyLeaveComponent } from './my-leave.component';

const routes: Routes = [
  {
    path: '**',
    component: MyLeaveComponent
  }
];

@NgModule({
  declarations: [MyLeaveComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class MyLeaveModule { }
