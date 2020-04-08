import { Component, OnInit } from "@angular/core";
import { MatDialogRef } from "@angular/material";
import { User } from "../models/user";
import { UsersService } from "../servives/users.service";
import { AlertService } from "app/services/alert.service";

@Component({
    selector: "app-save",
    templateUrl: "./save.component.html",
    styleUrls: ["./save.component.scss"]
})
export class SaveComponent implements OnInit {
    user: User;
    essRole: any = [];
    supervisorRole: any = [];
    adminRole: any = [];
    seletedRules: any = [];

    animals: any[] = [
        { name: "Dog", sound: "Woof!" },
        { name: "Cat", sound: "Meow!" },
        { name: "Cow", sound: "Moo!" },
        { name: "Fox", sound: "Wa-pa-pa-pa-pa-pa-pow!" }
    ];

    constructor(
        public _dialogRef: MatDialogRef<SaveComponent>,
        private userService: UsersService,
        private alertService: AlertService
    ) { }

    ngOnInit() {
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
        if (data.value != undefined)
            this.seletedRules.push(data.value.roleId);
        else {

        }
    }
}
