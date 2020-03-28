import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';

import { UserIdMappingComponent } from './user-id-mapping.component';

const routes: Routes = [
  {
    path: '**',
    component: UserIdMappingComponent
  }
];

@NgModule({
  declarations: [UserIdMappingComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class UserIdMappingModule { }
