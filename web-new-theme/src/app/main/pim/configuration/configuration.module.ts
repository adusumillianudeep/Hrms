import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: 'optional-fields',
    loadChildren: () => import('./optional-fields/optional-fields.module').then(m => m.OptionalFieldsModule)
  },
  {
    path: 'custom-fields',
    loadChildren: () => import('./custom-fields/custom-fields.module').then(m => m.CustomFieldsModule)
  },
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})
export class ConfigurationModule { }
