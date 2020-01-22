import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  {
    path: 'admin/user-management/users',
    loadChildren: () => import('./main/users/users.module').then(m => m.UsersModule)
  },
  {
    path: 'admin/user-management/user-roles',
    loadChildren: () => import('./main/user-roles/user-roles.module').then(m => m.UserRolesModule)
  },
  {
    path: '**',
    loadChildren: () => import('./main/dashboard/dashboard.module').then(m => m.DashboardModule)
  },
  // {
  //   path: '**',
  //   loadChildren: () => import('./login/login.module').then(m => m.LoginModule)
  // }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
