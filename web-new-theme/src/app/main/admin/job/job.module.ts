import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: 'work-shifts',
    loadChildren: () => import('./work-shifts/work-shifts.module').then(m => m.WorkShiftsModule)
  },
  {
    path: 'job-categories',
    loadChildren: () => import('./job-categories/job-categories.module').then(m => m.JobCategoriesModule)
  },
  {
    path: 'employment-status',
    loadChildren: () => import('./employment-status/employment-status.module').then(m => m.EmploymentStatusModule)
  },
  {
    path: 'pay-grades',
    loadChildren: () => import('./pay-grades/pay-grades.module').then(m => m.PayGradesModule)
  },
  {
    path: 'salary-components',
    loadChildren: () => import('./salary-components/salary-components.module').then(m => m.SalaryComponentsModule)
  },
  {
    path: 'job-titles',
    loadChildren: () => import('./job-titles/job-titles.module').then(m => m.JobTitlesModule)
  },
]


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})
export class JobModule { }
