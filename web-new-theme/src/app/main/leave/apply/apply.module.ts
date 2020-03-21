import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { ApplyComponent } from './apply.component';

const routes: Routes = [
  {
    path: '**',
    component: ApplyComponent
  }
];

@NgModule({
  declarations: [ApplyComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})

export class ApplyModule { }
