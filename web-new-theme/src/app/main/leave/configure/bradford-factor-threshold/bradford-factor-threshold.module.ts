import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { BradfordFactorThresholdComponent } from './bradford-factor-threshold.component';

const routes: Routes = [
  {
    path: '**',
    component: BradfordFactorThresholdComponent
  }
];

@NgModule({
  declarations: [BradfordFactorThresholdComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})

export class BradfordFactorThresholdModule { }
