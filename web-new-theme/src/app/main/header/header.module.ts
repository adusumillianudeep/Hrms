import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './header.component';
import { FuseSharedModule } from '@fuse/shared.module';

@NgModule({
  declarations: [HeaderComponent],
  imports: [
    CommonModule,
    FuseSharedModule
  ],
  exports: [HeaderComponent]
})
export class HeaderModule { }
