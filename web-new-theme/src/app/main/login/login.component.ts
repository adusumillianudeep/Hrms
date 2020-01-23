import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { FuseConfigService } from '@fuse/services/config.service';
import { fuseAnimations } from '@fuse/animations';
import { AuthenticationService } from './services/authentication.service';
import { Router } from '@angular/router';
import { FuseProgressBarService } from '@fuse/components/progress-bar/progress-bar.service';

@Component({
    selector: 'login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.scss'],
    encapsulation: ViewEncapsulation.None,
    animations: fuseAnimations
})
export class LoginComponent implements OnInit {
    loginForm: FormGroup;
    username: string;
    password: string;
    invalidUser: boolean;
    /**
     * Constructor
     *
     * @param {FuseConfigService} _fuseConfigService
     * @param {FormBuilder} _formBuilder
     */
    constructor(
        private _fuseConfigService: FuseConfigService,
        private _formBuilder: FormBuilder,
        private _auth: AuthenticationService,
        private _router: Router,
        private _fuseProgressBarService: FuseProgressBarService
    ) {
        // Configure the layout
        this._fuseConfigService.config = {
            layout: {
                navbar: {
                    hidden: true
                },
                toolbar: {
                    hidden: true
                },
                footer: {
                    hidden: true
                },
                sidepanel: {
                    hidden: true
                }
            }
        };
    }

    // -----------------------------------------------------------------------------------------------------
    // @ Lifecycle hooks
    // -----------------------------------------------------------------------------------------------------

    /**
     * On init
     */
    ngOnInit(): void {
        this.loginForm = this._formBuilder.group({
            email: ['', Validators.required],
            password: ['', Validators.required]
        });
    }

    login(): void {
        // this._fuseProgressBarService.show();

        this._router.navigate(['dashboard']);
        // this._auth.login(this.username, this.password).subscribe(res => {
        //     debugger;
        //     if (res) {
        //         this._router.navigate(['dashboard']);
        //     } else {
        //         this.invalidUser = true;
        //     }
        //     this._fuseProgressBarService.hide();
        // }, error => {
        //     this.invalidUser = true;
        //     this._fuseProgressBarService.hide();
        // });
    }
}
