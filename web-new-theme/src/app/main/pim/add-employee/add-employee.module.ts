import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { MatStepperModule, MatDatepickerModule, MatRadioModule } from '@angular/material';

import { AddEmployeeComponent } from './add-employee.component';
import { SaveComponent } from './save/save.component';
import { JobComponent } from './job/job.component';
import { EmploymentDetailsComponent } from './employment-details/employment-details.component';
import { PersonalDetailsComponent } from './personal-details/personal-details.component';
import { MemberShipsComponent } from './member-ships/member-ships.component';
import { AddMemberShipsComponent } from './member-ships/add-member-ships/add-member-ships.component';
import { DirectDepositComponent } from './direct-deposit/direct-deposit.component';
import { AddDirectDepositComponent } from './direct-deposit/add-direct-deposit/add-direct-deposit.component';
import { AddWizardComponent } from './add-wizard/add-wizard.component';

const routes: Routes = [
  // {
  //   path: 'add-wizard',
  //   component: AddWizardComponent
  // },
  {
    path: '**',
    component: AddEmployeeComponent
  }
];

@NgModule({
  declarations: [
    AddEmployeeComponent,
    SaveComponent,
    JobComponent,
    EmploymentDetailsComponent,
    PersonalDetailsComponent,
    MemberShipsComponent,
    AddMemberShipsComponent,
    DirectDepositComponent,
    AddDirectDepositComponent,
    AddWizardComponent
  ],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    MatStepperModule,
    MatDatepickerModule,
    MatRadioModule,
    RouterModule.forChild(routes)
  ],
  entryComponents: [
    SaveComponent,
    AddMemberShipsComponent
  ]
})

export class AddEmployeeModule { }
