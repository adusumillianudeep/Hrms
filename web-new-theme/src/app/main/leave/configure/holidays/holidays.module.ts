import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { HolidaysComponent } from './holidays.component';

const routes: Routes = [
  {
    path: '**',
    component: HolidaysComponent
  }
];

@NgModule({
  declarations: [HolidaysComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class HolidaysModule { }
