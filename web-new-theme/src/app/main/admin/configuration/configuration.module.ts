import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: 'email-settings',
    loadChildren: () => import('./email-settings/email-settings.module').then(m => m.EmailSettingsModule)
  },
  {
    path: 'email-notifications',
    loadChildren: () => import('./email-notifications/email-notifications.module').then(m => m.EmailNotificationsModule)
  },
  {
    path: 'localization',
    loadChildren: () => import('./localization/localization.module').then(m => m.LocalizationModule)
  },
  {
    path: 'authentication',
    loadChildren: () => import('./authentication/authentication.module').then(m => m.AuthenticationModule)
  },
  {
    path: 'directory-configuration',
    loadChildren: () => import('./directory-configurations/directory-configurations.module').then(m => m.DirectoryConfigurationsModule)
  },
]

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})
export class ConfigurationModule { }
