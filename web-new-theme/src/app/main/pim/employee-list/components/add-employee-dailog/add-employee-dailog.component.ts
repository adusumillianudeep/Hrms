import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { MatDialogRef } from '@angular/material';

@Component({
  selector: 'app-add-employee-dailog',
  templateUrl: './add-employee-dailog.component.html',
  styleUrls: ['./add-employee-dailog.component.scss']
})
export class AddEmployeeDailogComponent implements OnInit {


  constructor(
    private _router: Router,
    public dialogRef: MatDialogRef<AddEmployeeDailogComponent>) { }

  ngOnInit() {
  }

  gotoWizard(): void {
    this._router.navigate(['pim/employee-list/add-wizard']);
    this.dialogRef.close();

  }

}
