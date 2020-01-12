import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { SharedModule } from './shared.module';
import { MenuComponent } from './layouts/menu/menu.component';
import { SidebarComponent } from './layouts/sidebar/sidebar.component';
import { ContentTopComponent } from './layouts/content-top/content-top.component';
import { PagesTopComponent } from './layouts/pages-top/pages-top.component';
import { RightConfigComponent } from './layouts/right-config/right-config.component';
import { GlobalService } from "./services/global.service";
import {InputSwitchModule} from 'primeng/inputswitch';
import { NotificationComponent } from './components/notification/notification.component';
import { LoadingComponent } from './components/loading/loading.component';

@NgModule({
    imports: [
        CommonModule,
        RouterModule,
        SharedModule,
        InputSwitchModule
    ],
    providers: [
        GlobalService
    ],
    declarations: [
        MenuComponent,
        SidebarComponent,
        PagesTopComponent,
        ContentTopComponent,
        RightConfigComponent,
        NotificationComponent,
        LoadingComponent
    ],
    exports: [
        SidebarComponent,
        PagesTopComponent,
        ContentTopComponent,
        RightConfigComponent,
        NotificationComponent,
        LoadingComponent
    ]
})
export class LayoutModule { }
