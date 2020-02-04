import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserRolesComponent } from './user-roles.component';
import { Routes, RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { SaveComponent } from './save/save.component';
import { AdminComponent } from './admin/admin.component';
import { EssComponent } from './ess/ess.component';
import { SupervisorComponent } from './supervisor/supervisor.component';
import { HeaderModule } from 'app/main/header/header.module';

const routes: Routes = [
  {
    path: 'add',
    component: SaveComponent
  },
  {
    path: 'edit/:id',
    component: SaveComponent
  },
  {
    path: '**',
    component: UserRolesComponent
  }
];

@NgModule({
  declarations: [UserRolesComponent, SaveComponent, AdminComponent, EssComponent, SupervisorComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class UserRolesModule { }
