import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavigationComponent } from './navigation.component';
import { MenuListItemComponent } from './menu-list-item/menu-list-item.component';
import { TopNavComponent } from './top-nav/top-nav.component';
import { SharedModule } from '../shared/shared.module';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [NavigationComponent, MenuListItemComponent, TopNavComponent],
  imports: [
    CommonModule,
    SharedModule,
    RouterModule
  ],
  exports: [NavigationComponent]
})
export class NavigationModule { }
