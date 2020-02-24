import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CustomFieldsComponent } from './custom-fields.component';
import { Routes, RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';

const routes: Routes = [
  {
    path: '**',
    component: CustomFieldsComponent
  }
];

@NgModule({
  declarations: [CustomFieldsComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class CustomFieldsModule { }
