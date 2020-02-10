import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: 'announcements',
    loadChildren: () => import('./announcements/announcements.module').then(m => m.AnnouncementsModule)
  },
  {
    path: 'nationalities',
    loadChildren: () => import('./nationalities/nationalities.module').then(m => m.NationalitiesModule)
  },
  {
    path: 'qualifications',
    loadChildren: () => import('./qualifications/qualifications.module').then(m => m.QualificationsModule)
  },
  {
    path: 'competencies',
    loadChildren: () => import('./competencies/competencies.module').then(m => m.CompetenciesModule)
  },
  {
    path: 'job',
    loadChildren: () => import('./job/job.module').then(m => m.JobModule)
  },
  {
    path: 'organization',
    loadChildren: () => import('./organization/organization.module').then(m => m.OrganizationModule)
  },
  {
    path: 'user-management',
    loadChildren: () => import('./user-management/user-management.module').then(m => m.UserManagementModule)
  },
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})
export class AdminModule { }
