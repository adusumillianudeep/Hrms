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
  {
    path: 'reporting-methods',
    loadChildren: () => import('./reporting-methods/reporting-methods.module').then(m => m.ReportingMethodsModule)
  },
  {
    path: 'add-employee-wizard',
    loadChildren: () => import('./add-employee-wizard/add-employee-wizard.module').then(m => m.AddEmployeeWizardModule)
  },
  {
    path: 'termination-reasons',
    loadChildren: () => import('./termination-reasons/termination-reasons.module').then(m => m.TerminationReasonsModule)
  },
  {
    path: 'document-templates',
    loadChildren: () => import('./document-templates/document-templates.module').then(m => m.DocumentTemplatesModule)
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
