import { Component, OnInit, ViewChild } from '@angular/core';
import { MatTableDataSource, MatPaginator } from '@angular/material';
import { SelectionModel } from '@angular/cdk/collections';

@Component({
  selector: 'app-user-roles',
  templateUrl: './user-roles.component.html',
  styleUrls: ['./user-roles.component.scss']
})
export class UserRolesComponent implements OnInit {

  Users: User[] = [
    { id: 1, userrole: 'Asset Manager', roleType: 'Admin' },
    { id: 2, userrole: 'Global Salary Admin', roleType: 'Admin' },
    { id: 3, userrole: 'Recruitment Manager', roleType: 'Admin' },
    { id: 4, userrole: 'Time Manager', roleType: 'Admin' },
    { id: 5, userrole: 'Project Manager', roleType: 'Admin' },
    { id: 6, userrole: 'Recruitment Manager', roleType: 'Admin' }
  ];

  ngOnInit() {

  }

  add(): void {

  }

}

export interface User {
  id: number;
  userrole: string;
  roleType: string;
}





