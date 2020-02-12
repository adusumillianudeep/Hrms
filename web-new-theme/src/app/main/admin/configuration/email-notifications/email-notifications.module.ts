import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmailNotificationsComponent } from './email-notifications.component';
import { Routes, RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';

const routes: Routes = [
  {
    path: '**',
    component: EmailNotificationsComponent
  }
];

@NgModule({
  declarations: [EmailNotificationsComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class EmailNotificationsModule { }
