import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmailSettingsComponent } from './email-settings.component';
import { Routes, RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';

const routes: Routes = [
  {
    path: '**',
    component: EmailSettingsComponent
  }
];

@NgModule({
  declarations: [EmailSettingsComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class EmailSettingsModule { }
