import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';

import { IpRestrictionComponent } from './ip-restriction.component';

const routes: Routes = [
  {
    path: '**',
    component: IpRestrictionComponent
  }
];


@NgModule({
  declarations: [IpRestrictionComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class IpRestrictionModule { }
