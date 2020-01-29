import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LocationsComponent } from './locations.component';
import { Routes, RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { SaveComponent } from './save/save.component';
import { HeaderModule } from 'app/main/header/header.module';

const routes: Routes = [
  {
    path: '**',
    component: LocationsComponent
  }
];

@NgModule({
  declarations: [LocationsComponent, SaveComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ],
  entryComponents: [SaveComponent]
})
export class LocationsModule { }
