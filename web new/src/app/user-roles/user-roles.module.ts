import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserRolesComponent } from './user-roles.component';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    component: UserRolesComponent
  }
];

@NgModule({
  declarations: [UserRolesComponent],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})
export class UserRolesModule { }
