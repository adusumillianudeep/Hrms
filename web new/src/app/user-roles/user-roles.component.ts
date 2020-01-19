import { Component, OnInit, ViewChild } from '@angular/core';
import { CommonService } from '../services/common.service';
import { MatTableDataSource, MatPaginator } from '@angular/material';
import { SelectionModel } from '@angular/cdk/collections';

@Component({
  selector: 'app-user-roles',
  templateUrl: './user-roles.component.html',
  styleUrls: ['./user-roles.component.scss']
})
export class UserRolesComponent implements OnInit {

  dataSource = new MatTableDataSource<User>(Users);
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  displayedColumns: string[] = ['select', 'userrole', 'roleType', 'actions'];
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
    return `${this.selection.isSelected(row) ? 'deselect' : 'select'} row ${row.userrole + 1}`;
  }

}

export interface User {
  userrole: string;
  roleType: string;
}

const Users: User[] = [
  { userrole: 'Asset Manager', roleType: 'Admin' },
  { userrole: 'Global Salary Admin', roleType: 'Admin' },
  { userrole: 'Recruitment Manager', roleType: 'Admin' },
  { userrole: 'Time Manager', roleType: 'Admin' },
  { userrole: 'Project Manager', roleType: 'Admin' },
  { userrole: 'Recruitment Manager', roleType: 'Admin' }
];



