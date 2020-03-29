import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { MatStepperModule } from '@angular/material';

import { AddEmployeeComponent } from './add-employee.component';
import { SaveComponent } from './save/save.component';

const routes: Routes = [
  {
    path: '**',
    component: AddEmployeeComponent
  }
];

@NgModule({
  declarations: [AddEmployeeComponent, SaveComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    MatStepperModule,
    RouterModule.forChild(routes)
  ],
  entryComponents: [SaveComponent]
})

export class AddEmployeeModule { }
