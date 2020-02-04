import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProcessEeoFillingComponent } from './process-eeo-filling.component';
import { Routes, RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';

const routes: Routes = [
  {
    path: '**',
    component: ProcessEeoFillingComponent
  }
];

@NgModule({
  declarations: [ProcessEeoFillingComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class ProcessEeoFillingModule { }
