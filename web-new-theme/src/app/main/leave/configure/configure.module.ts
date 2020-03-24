import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: 'leave-period',
    loadChildren: () => import('./leave-period/leave-period.module').then(m => m.LeavePeriodModule)
  },
  {
    path: 'leave-types',
    loadChildren: () => import('./leave-types/leave-types.module').then(m => m.LeaveTypesModule)
  },
  {
    path: 'work-week',
    loadChildren: () => import('./work-week/work-week.module').then(m => m.WorkWeekModule)
  },
  {
    path: 'holidays',
    loadChildren: () => import('./holidays/holidays.module').then(m => m.HolidaysModule)
  },
  {
    path: 'bradford-factor-threshold',
    loadChildren: () => import('./bradford-factor-threshold/bradford-factor-threshold.module').then(m => m.BradfordFactorThresholdModule)
  },
  {
    path: 'working-weekends',
    loadChildren: () => import('./working-weekends/working-weekends.module').then(m => m.WorkingWeekendsModule)
  },
  {
    path: 'notifications',
    loadChildren: () => import('./notifications/notifications.module').then(m => m.NotificationsModule)
  },
  {
    path: 'calendar-configuration',
    loadChildren: () => import('./calendar-configuration/calendar-configuration.module').then(m => m.CalendarConfigurationModule)
  }
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})
export class ConfigureModule { }
