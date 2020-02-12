import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuditTrailComponent } from './audit-trail.component';
import { Routes, RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';

const routes: Routes = [
  {
    path: '**',
    component: AuditTrailComponent
  }
];


@NgModule({
  declarations: [AuditTrailComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class AuditTrailModule { }
