import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CustomFieldsComponent } from './custom-fields.component';
import { Routes, RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { AddComponent } from './add/add.component';
import { AddFieldComponent } from './add-field/add-field.component';
import { AddTitleComponent } from './add-title/add-title.component';
import { FieldsComponent } from './fields/fields.component';

const routes: Routes = [
  {
    path: 'add',
    component: AddComponent
  },
  {
    path: '',
    component: CustomFieldsComponent
  }
];

@NgModule({
  declarations: [CustomFieldsComponent, AddComponent, AddFieldComponent, AddTitleComponent, FieldsComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
    
  ]
})
export class CustomFieldsModule { }
