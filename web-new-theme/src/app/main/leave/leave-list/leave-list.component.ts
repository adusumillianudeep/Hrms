import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-leave-list',
  templateUrl: './leave-list.component.html',
  styleUrls: ['./leave-list.component.scss']
})
export class LeaveListComponent implements OnInit {

  data: any[] = [
    { employee: "Nina Patel", date: "Wed, 04 Mar 2020 to Mon, 09 Mar 2020", leaveType: "Casual Leave", leaveBalance: "0.00", days: "4.00", status: "Taken(2.00),Pending, Approval(2.00)" },
    { employee: "Nina Patel", date: "Mon, 02 Mar 2020", leaveType: "Casual Leave", leaveBalance: "0.00", days: "4.00", status: "Pending, Approval(2.00)" },
    { employee: "Pavithrra S", date: "Fri, 31 Jan 2020(18:30 - 23:00) Half Day", leaveType: "Vacation Leave - US", leaveBalance: "0.00", days: "4.00", status: "Pending, Approval(2.00)" },
  ];

  constructor() { }

  ngOnInit() {
  }

}
