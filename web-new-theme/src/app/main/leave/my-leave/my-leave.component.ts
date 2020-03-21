import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-my-leave',
  templateUrl: './my-leave.component.html',
  styleUrls: ['./my-leave.component.scss']
})
export class MyLeaveComponent implements OnInit {

  data: any[] = [
    { employee: "Pavithrra S", date: 'Fri, 31 Jan 2020', leaveType: "Vacation Leave - US", balance: "0.00", days: 0.50, status: "Pending Approval(0.50)" },
    { employee: "Pavithrra S", date: 'Fri, 31 Jan 2020', leaveType: "Vacation Leave - US", balance: "0.00", days: 0.50, status: "Pending Approval(0.50)" },
  ];

  constructor() { }

  ngOnInit() {
  }

}
