import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';

import { GeoRestrictionComponent } from './geo-restriction.component';

const routes: Routes = [
  {
    path: '**',
    component: GeoRestrictionComponent
  }
];

@NgModule({
  declarations: [GeoRestrictionComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class GeoRestrictionModule { }
