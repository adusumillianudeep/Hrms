import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { CalendarConfigurationComponent } from './calendar-configuration.component';

const routes: Routes = [
  {
    path: '**',
    component: CalendarConfigurationComponent
  }
];

@NgModule({
  declarations: [CalendarConfigurationComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class CalendarConfigurationModule { }
