import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: 'user-settings',
    loadChildren: () => import('./user-settings/user-settings.module').then(m => m.UserSettingsModule)
  },
  {
    path: 'user-id-mapping',
    loadChildren: () => import('./user-id-mapping/user-id-mapping.module').then(m => m.UserIdMappingModule)
  },
  {
    path: 'absent-schedule',
    loadChildren: () => import('./absent-schedule/absent-schedule.module').then(m => m.AbsentScheduleModule)
  },
  {
    path: 'regularization',
    loadChildren: () => import('./regularization/regularization.module').then(m => m.RegularizationModule)
  },
  {
    path: 'payperiod-settings',
    loadChildren: () => import('./payperiod-settings/payperiod-settings.module').then(m => m.PayperiodSettingsModule)
  },
  {
    path: 'ip-restriction',
    loadChildren: () => import('./ip-restriction/ip-restriction.module').then(m => m.IpRestrictionModule)
  },
  {
    path: 'geo-restriction',
    loadChildren: () => import('./geo-restriction/geo-restriction.module').then(m => m.GeoRestrictionModule)
  }
];


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})
export class SettingsModule { }
