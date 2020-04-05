import { Component, OnInit } from '@angular/core';
import { AddEmployeeDailogComponent } from './components/add-employee-dailog/add-employee-dailog.component';
import { MatDialog } from '@angular/material';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.scss']
})
export class EmployeeListComponent implements OnInit {

  constructor(public dialog: MatDialog) { }

  public ngOnInit() { }

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
