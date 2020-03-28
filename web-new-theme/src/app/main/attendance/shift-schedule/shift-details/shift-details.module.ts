import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';

import { ShiftDetailsComponent } from './shift-details.component';

const routes: Routes = [
  {
    path: '**',
    component: ShiftDetailsComponent
  }
];

@NgModule({
  declarations: [ShiftDetailsComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class ShiftDetailsModule { }
