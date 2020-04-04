import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { MatStepperModule, MatDatepickerModule, MatRadioModule } from '@angular/material';
import { AddEmployeeComponent } from './add-employee.component';
import { SaveComponent } from './save/save.component';
import { JobComponent } from './job/job.component';

const routes: Routes = [
  {
    path: '**',
    component: AddEmployeeComponent
  }
];

@NgModule({
  declarations: [AddEmployeeComponent, SaveComponent, JobComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    MatStepperModule,
    MatDatepickerModule,
    MatRadioModule,
    RouterModule.forChild(routes)
  ],
  entryComponents: [SaveComponent]
})

export class AddEmployeeModule { }
