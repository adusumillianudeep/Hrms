import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UsersComponent } from './users.component';
import { Routes, RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { SaveComponent } from './save/save.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatAutocompleteModule } from '@angular/material';

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
    FormsModule,
    ReactiveFormsModule,
    MatAutocompleteModule,
    RouterModule.forChild(routes)
  ],
  entryComponents: [SaveComponent]
})
export class UsersModule { }
