import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: 'memberships',
    loadChildren: () => import('./memberships/memberships.module').then(m => m.MembershipsModule)
  },
  {
    path: 'languages',
    loadChildren: () => import('./languages/languages.module').then(m => m.LanguagesModule)
  },
  {
    path: 'licenses',
    loadChildren: () => import('./licenses/licenses.module').then(m => m.LicensesModule)
  },
  {
    path: 'education',
    loadChildren: () => import('./education/education.module').then(m => m.EducationModule)
  },
  {
    path: 'skills',
    loadChildren: () => import('./skills/skills.module').then(m => m.SkillsModule)
  }
]

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})
export class QualificationsModule { }
