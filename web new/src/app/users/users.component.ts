import { Component, OnInit } from '@angular/core';
import { CommonService } from '../services/common.service';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.scss']
})
export class UsersComponent implements OnInit {

  constructor(private commonService: CommonService) { }
  displayedColumns: string[] = ['Username', 'userrole', 'Employeename', 'status'];
  columnsToDisplay: string[] = this.displayedColumns.slice();
  dataSource:User[];
  ngOnInit() {
    this.commonService.loginChange(true);
    this.dataSource =  [
      {Username: "Anudeep01", userrole: 'Admin', Employeename: "Anudeep" ,status: "Enabled"},
      {Username: "Raghavendra02", userrole: 'Supervisor', Employeename: "Raghavendra", status: "Enabled"},
      {Username: "Sowjana04", userrole: 'Lead', Employeename: "Sowjana", status: "Enabled"}
    ];
  }

  
  

}

export interface User {
  Username: string;
  userrole: string;
  Employeename: string;
  status: string;
}
