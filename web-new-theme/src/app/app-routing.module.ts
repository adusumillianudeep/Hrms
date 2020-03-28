import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';


const routes: Routes = [

  {
    path: 'admin',
    loadChildren: () => import('./main/admin/admin.module').then(m => m.AdminModule)
  },
  {
    path: 'pim',
    loadChildren: () => import('./main/pim/pim.module').then(m => m.PimModule)
  },
  {
    path: 'leave',
    loadChildren: () => import('./main/leave/leave.module').then(m => m.LeaveModule)
  },
  {
    path: 'attendance',
    loadChildren: () => import('./main/attendance/attendance.module').then(m => m.AttendanceModule)
  },
  {
    path: 'dashboard',
    loadChildren: () => import('./main/dashboard/dashboard.module').then(m => m.DashboardModule)
  },
  {
    path: 'error-404/:id',
    component: PageNotFoundComponent
  },
  {
    path: '',
    loadChildren: () => import('./main/login/login.module').then(m => m.LoginModule)
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
