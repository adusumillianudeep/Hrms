import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: 'shift-details',
    loadChildren: () => import('./shift-details/shift-details.module').then(m => m.ShiftDetailsModule)
  },
  {
    path: 'shift-mapping',
    loadChildren: () => import('./shift-mapping/shift-mapping.module').then(m => m.ShiftMappingModule)
  }
];


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})

export class ShiftScheduleModule { }
