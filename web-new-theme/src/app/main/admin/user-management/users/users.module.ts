import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UsersComponent } from './users.component';
import { Routes, RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { SaveComponent } from './save/save.component';

const routes: Routes = [
  {
    path: '**',
    component: UsersComponent
  }
];


@NgModule({
  declarations: [UsersComponent, SaveComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    RouterModule.forChild(routes)
  ],
  entryComponents: [SaveComponent]
})
export class UsersModule { }
