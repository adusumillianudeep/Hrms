import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { Router } from '@angular/router';
import { MatDialogRef, MatCheckboxChange } from '@angular/material';
import { fuseAnimations } from '@fuse/animations';
import { EmployeeData } from '../../models/employee-data';
import { AddEmployeeService } from '../../services/add-employee.service';

@Component({
  selector: 'app-add-employee-dailog',
  templateUrl: './add-employee-dailog.component.html',
  styleUrls: ['./add-employee-dailog.component.scss'],
  encapsulation: ViewEncapsulation.None,
  animations: fuseAnimations
})
export class AddEmployeeDailogComponent implements OnInit {

  empData: EmployeeData;

  constructor(
    private _router: Router,
    private _addEmployeeService: AddEmployeeService,
    public dialogRef: MatDialogRef<AddEmployeeDailogComponent>) {

    this.empData = new EmployeeData();
  }

  ngOnInit() {
  }

  gotoWizard(): void {
    this._addEmployeeService.employeeData = this.empData;
    this._router.navigate(['pim/employee-list/add-wizard']);
    this.dialogRef.close();
  }

  onChange(event: MatCheckboxChange) {
    this.empData.addLoginDetail = event.checked;
  }
}
