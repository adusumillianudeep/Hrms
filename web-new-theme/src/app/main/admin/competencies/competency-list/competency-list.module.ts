import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CompetencyListComponent } from './competency-list.component';
import { Routes, RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';

const routes: Routes = [
  {
    path: '**',
    component: CompetencyListComponent
  }
];

@NgModule({
  declarations: [CompetencyListComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes),
  ]
})
export class CompetencyListModule { }
