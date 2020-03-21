import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { BradfordFactorComponent } from './bradford-factor.component';

const routes: Routes = [
  {
    path: '**',
    component: BradfordFactorComponent
  }
];

@NgModule({
  declarations: [BradfordFactorComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class BradfordFactorModule { }
