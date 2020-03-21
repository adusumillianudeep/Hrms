import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: 'apply',
    loadChildren: () => import('./apply/apply.module').then(m => m.ApplyModule)
  },
  {
    path: 'assing',
    loadChildren: () => import('./assign/assign.module').then(m => m.AssignModule)
  },
  {
    path: 'bulk-assign',
    loadChildren: () => import('./bulk-assign/bulk-assign.module').then(m => m.BulkAssignModule)
  },
  {
    path: 'entitlements',
    loadChildren: () => import('./entitlement/entitlement.module').then(m => m.EntitlementModule)
  },
  {
    path: 'configure',
    loadChildren: () => import('./configure/configure.module').then(m => m.ConfigureModule)
  },
  {
    path: 'calendar',
    loadChildren: () => import('./calendar/calendar.module').then(m => m.CalendarModule)
  },
  {
    path: 'my-leave',
    loadChildren: () => import('./my-leave/my-leave.module').then(m => m.MyLeaveModule)
  },
  {
    path: 'report',
    loadChildren: () => import('./report/report.module').then(m => m.ReportModule)
  },
  {
    path: 'leave-list',
    loadChildren: () => import('./leave-list/leave-list.module').then(m => m.LeaveListModule)
  }
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})

export class LeaveModule { }
