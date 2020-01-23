import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { FuseSharedModule } from '@fuse/shared.module';
import { LoginComponent } from './login.component';

const routes = [
    {
        path     : '**',
        component: LoginComponent
    }
];

@NgModule({
    declarations: [
        LoginComponent
    ],
    imports     : [
        RouterModule.forChild(routes),
        FuseSharedModule
    ]
})
export class LoginModule
{
}
