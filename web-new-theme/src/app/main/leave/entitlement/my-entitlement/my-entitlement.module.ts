import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { MyEntitlementComponent } from './my-entitlement.component';

const routes: Routes = [
  {
    path: '**',
    component: MyEntitlementComponent
  }
];

@NgModule({
  declarations: [MyEntitlementComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class MyEntitlementModule { }
