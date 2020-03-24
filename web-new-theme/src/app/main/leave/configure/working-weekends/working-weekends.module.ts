import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { WorkingWeekendsComponent } from './working-weekends.component';


const routes: Routes = [
  {
    path: '**',
    component: WorkingWeekendsComponent
  }
];

@NgModule({
  declarations: [WorkingWeekendsComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class WorkingWeekendsModule { }
