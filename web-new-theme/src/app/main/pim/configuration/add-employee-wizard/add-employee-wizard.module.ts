import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AddEmployeeWizardComponent } from './add-employee-wizard.component';
import { Routes, RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { FieldComponent } from './field/field.component';

const routes: Routes = [
  {
    path: '**',
    component: AddEmployeeWizardComponent
  }
];

@NgModule({
  declarations: [AddEmployeeWizardComponent, FieldComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class AddEmployeeWizardModule { }
