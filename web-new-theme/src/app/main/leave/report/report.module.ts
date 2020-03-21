import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: 'leave-usage',
    loadChildren: () => import('./leave-usage//leave-usage.module').then(m => m.LeaveUsageModule)
  },
  {
    path: 'bradford-factor',
    loadChildren: () => import('./bradford-factor//bradford-factor.module').then(m => m.BradfordFactorModule)
  },
  {
    path: 'myleave-usage',
    loadChildren: () => import('./my-leave-usage//my-leave-usage.module').then(m => m.MyLeaveUsageModule)
  }
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})
export class ReportModule { }
