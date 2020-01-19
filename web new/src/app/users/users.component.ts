import { Component, OnInit, ViewChild } from '@angular/core';
import { CommonService } from '../services/common.service';
import { MatTableDataSource, MatPaginator } from '@angular/material';
import { SelectionModel } from '@angular/cdk/collections';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.scss']
})
export class UsersComponent implements OnInit {

  dataSource = new MatTableDataSource<User>(Users);
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  displayedColumns: string[] = ['select', 'username', 'userrole', 'employeename', 'status', 'actions'];
  selection = new SelectionModel<User>(true, []);

  constructor(private commonService: CommonService) { }


  ngOnInit() {
    this.commonService.loginChange(true);
    this.dataSource.paginator = this.paginator;
  }

  /** Whether the number of selected elements matches the total number of rows. */
  isAllSelected() {
    const numSelected = this.selection.selected.length;
    const numRows = this.dataSource.data.length;
    return numSelected === numRows;
  }

  /** Selects all rows if they are not all selected; otherwise clear selection. */
  masterToggle() {
    this.isAllSelected() ?
      this.selection.clear() :
      this.dataSource.data.forEach(row => this.selection.select(row));
  }

  /** The label for the checkbox on the passed row */
  checkboxLabel(row?: User): string {
    if (!row) {
      return `${this.isAllSelected() ? 'select' : 'deselect'} all`;
    }
    return `${this.selection.isSelected(row) ? 'deselect' : 'select'} row ${row.username + 1}`;
  }

}

export interface User {
  username: string;
  userrole: string;
  employeename: string;
  status: string;
}

const Users: User[] = [
  { username: "Anudeep01", userrole: 'Admin', employeename: "Anudeep", status: "Enabled" },
  { username: "Raghavendra02", userrole: 'Supervisor', employeename: "Raghavendra", status: "Enabled" },
  { username: "Sowjana04", userrole: 'Lead', employeename: "Sowjana", status: "Enabled" }
];
