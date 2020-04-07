import { Component, OnInit } from '@angular/core';
import { AddEmployeeDailogComponent } from './components/add-employee-dailog/add-employee-dailog.component';
import { MatDialog } from '@angular/material';
import { Router } from '@angular/router';
import { AlertService } from 'app/services/alert.service';
import { EmployeeService } from './services/employee.service';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.scss']
})
export class EmployeeListComponent implements OnInit {

  data;

  constructor(
    public dialog: MatDialog,
    private _router: Router,
    private _alertService: AlertService,
    private _employeeService: EmployeeService) {

  }

  public ngOnInit() { 

    this._getEmployees();
  }





  private _getEmployees(): void {
    this._employeeService.getList().subscribe(t => {
      this.data = t;
    });
  }


  openAddEmployeeDialog(): void {
    const dialogRef = this.dialog.open(AddEmployeeDailogComponent, {
      width: '800px',
      height: '600px',
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }

}
