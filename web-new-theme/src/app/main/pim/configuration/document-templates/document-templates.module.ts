import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DocumentTemplatesComponent } from './document-templates.component';
import { Routes, RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';

const routes: Routes = [
  {
    path: '**',
    component: DocumentTemplatesComponent
  }
];

@NgModule({
  declarations: [DocumentTemplatesComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes)
  ]
})
export class DocumentTemplatesModule { }
