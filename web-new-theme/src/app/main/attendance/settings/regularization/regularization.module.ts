import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';

import { RegularizationComponent } from './regularization.component';

const routes: Routes = [
  {
    path: '**',
    component: RegularizationComponent
  }
];

@NgModule({
  declarations: [RegularizationComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class RegularizationModule { }
