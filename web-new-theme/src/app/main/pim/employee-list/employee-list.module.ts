import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeListComponent } from './employee-list.component';
import { Routes, RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { AddEmployeeWizardComponent } from './components/add-employee-wizard/add-employee-wizard.component';
import { AddEmployeeDailogComponent } from './components/add-employee-dailog/add-employee-dailog.component';
import { PersonalDetailsComponent } from './components/personal-details/personal-details.component';
import { JobProfilesComponent } from './components/job-profiles/job-profiles.component';
import { ComponentLoaderComponent } from './components/component-loader/component-loader.component';
import { ComponentLoaderDirective } from './directives/component-loader.directive';
import { MoreInfoComponent } from './components/more-info/more-info.component';

const routes: Routes = [
  {
    path: 'add-wizard',
    component: AddEmployeeWizardComponent
  },
  {
    path: '',
    component: EmployeeListComponent
  }
];

@NgModule({
  declarations: [
    EmployeeListComponent,
    AddEmployeeWizardComponent,
    AddEmployeeDailogComponent,
    PersonalDetailsComponent,
    JobProfilesComponent,
    ComponentLoaderComponent,
    ComponentLoaderDirective,
    MoreInfoComponent
  ],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ],
  entryComponents: [
    AddEmployeeDailogComponent,
    PersonalDetailsComponent,
    JobProfilesComponent,
    MoreInfoComponent
  ]
})
export class EmployeeListModule { }
