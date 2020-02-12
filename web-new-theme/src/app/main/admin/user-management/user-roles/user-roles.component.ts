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
    { userrole: 'Asset Manager', roleType: 'Admin' },
    { userrole: 'Global Salary Admin', roleType: 'Admin' },
    { userrole: 'Recruitment Manager', roleType: 'Admin' },
    { userrole: 'Time Manager', roleType: 'Admin' },
    { userrole: 'Project Manager', roleType: 'Admin' },
    { userrole: 'Recruitment Manager', roleType: 'Admin' }
  ];

  ngOnInit() {

  }

}

export interface User {
  userrole: string;
  roleType: string;
}





