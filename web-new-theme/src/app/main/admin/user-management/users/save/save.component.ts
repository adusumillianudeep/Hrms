import { Component, OnInit } from "@angular/core";
import { MatDialogRef } from "@angular/material";
import { User } from "../models/user";
import { UsersService } from "../servives/users.service";
import { AlertService } from "app/services/alert.service";
import { map, startWith } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { FormControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import * as _ from 'lodash';

@Component({
    selector: "app-save",
    templateUrl: "./save.component.html",
    styleUrls: ["./save.component.scss"]
})

export class SaveComponent implements OnInit {
    userForm: FormGroup;
    user: User;
    essRole: any = [];
    employees: any[];
    filteredStates: Observable<any[]>;
    supervisorRole: any = [];
    adminRole: any = [];
    seletedRules: any = [];

    employeeCtrl: FormControl = new FormControl();
    // matcher = new MyErrorStateMatcher();

    animals: any[] = [
        { name: "Dog", sound: "Woof!" },
        { name: "Cat", sound: "Meow!" },
        { name: "Cow", sound: "Moo!" },
        { name: "Fox", sound: "Wa-pa-pa-pa-pa-pa-pow!" }
    ];

    constructor(
        public _dialogRef: MatDialogRef<SaveComponent>,
        private userService: UsersService,
        private alertService: AlertService,
        private _formBuilder: FormBuilder,
    ) { }

    ngOnInit() {

        this.userForm = this._formBuilder.group({
            employeeName: ['', Validators.required],
            userName: ['', [Validators.required, Validators.minLength(5)]],
            essRole: ['', Validators.required],
            supervisorRole: ['', Validators.required],
            adminRole: [''],
            status: [''],
            password: ['', Validators.required],
            confirmPassword: ['', Validators.required],
        }, { validator: this.checkPasswords });

        this.user = new User();
        this.getRoles();
    }

    getRoles() {
        this.userService.getRoles().subscribe(res => {
            if (res.length > 0) {
                this.adminRole = res.filter(x => x.roleTypeName == 'Admin');
                this.essRole = res.filter(x => x.roleTypeName == 'ESES');
                this.supervisorRole = res.filter(x => x.roleTypeName == 'Supervisor');
            }

        });
    }
    saveUser() {

        debugger;
        // stop here if form is invalid
        if (this.userForm.invalid) {
            this.alertService.error("Please fill the required field.");
            return;
        }

        this.user.roleIds = this.seletedRules;
        this.userService.saveUser(this.user).subscribe(
            res => {
                this.alertService.success("Added");
                this._dialogRef.close();
            },
            () => {
                this.alertService.error("Failed to add");
            }
        );
    }
    changeRole(data: any) {
        if (!data.value) {
            this.seletedRules.push(data.value.roleId);
        }
    }

    onSearchChange(searchText: string) {
        
        this.userService.onSearchChange(searchText)
            .subscribe(data => {
                this.employees = data;
                this.filteredStates = this.employeeCtrl.valueChanges
                    .pipe(
                        startWith(''),
                        map(value => this._filter(value))
                    )
            })
    }

    _filter(searchText: any) {
        return this.employees.filter(emp =>
            emp.fullName.toLowerCase().indexOf(searchText.toLowerCase()) === 0);
    }

    checkPasswords(group: FormGroup) {
        // here we have the 'passwords' group

        let pass = group.controls.password.value;
        let confirmPass = group.controls.confirmPassword.value;

        return pass === confirmPass ? null : { notSame: true }
    }
}