import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CostCentersComponent } from './cost-centers.component';
import { Routes, RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { HeaderModule } from 'app/main/header/header.module';
import { SaveComponent } from './save/save.component';

const routes: Routes = [
  {
    path: '**',
    component: CostCentersComponent
  }
];

@NgModule({
  declarations: [CostCentersComponent, SaveComponent],
  entryComponents: [SaveComponent],
  imports: [
    CommonModule,
    FuseSharedModule,
    HeaderModule,
    RouterModule.forChild(routes),
  ]
})
export class CostCentersModule { }
