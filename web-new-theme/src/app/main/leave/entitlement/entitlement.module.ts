import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: 'add-entitlements',
    loadChildren: () => import('./add-entitlement/add-entitlement.module').then(m => m.AddEntitlementModule)
  },
  {
    path: 'my-entitlements',
    loadChildren: () => import('./my-entitlement/my-entitlement.module').then(m => m.MyEntitlementModule)
  },
  {
    path: 'list-entitlements',
    loadChildren: () => import('./list-entitlement/list-entitlement.module').then(m => m.ListEntitlementModule)
  }
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})
export class EntitlementModule { }
