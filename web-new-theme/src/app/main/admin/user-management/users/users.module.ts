import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UsersComponent } from './users.component';
import { Routes, RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';

const routes: Routes = [
  {
    path: '**',
    component: UsersComponent
  }
];


@NgModule({
  declarations: [UsersComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    RouterModule.forChild(routes)
  ]
})
export class UsersModule { }
