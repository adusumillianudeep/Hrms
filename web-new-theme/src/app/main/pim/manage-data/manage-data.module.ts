import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: 'bulk-update',
    loadChildren: () => import('./bulk-update/bulk-update.module').then(m => m.BulkUpdateModule)
  },
  {
    path: 'employee-data-export',
    loadChildren: () => import('./employee-data-export/employee-data-export.module').then(m => m.EmployeeDataExportModule)
  },
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})
export class ManageDataModule { }
