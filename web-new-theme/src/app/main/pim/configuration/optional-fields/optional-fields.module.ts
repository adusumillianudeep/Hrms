import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { OptionalFieldsComponent } from './optional-fields.component';
import { Routes, RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';

const routes: Routes = [
  {
    path: '**',
    component: OptionalFieldsComponent
  }
];

@NgModule({
  declarations: [OptionalFieldsComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class OptionalFieldsModule { }
