import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TerminationReasonsComponent } from './termination-reasons.component';
import { Routes, RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';

const routes: Routes = [
  {
    path: '**',
    component: TerminationReasonsComponent
  }
];

@NgModule({
  declarations: [TerminationReasonsComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class TerminationReasonsModule { }
