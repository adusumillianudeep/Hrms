import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-my-leave-usage',
  templateUrl: './my-leave-usage.component.html',
  styleUrls: ['./my-leave-usage.component.scss']
})
export class MyLeaveUsageComponent implements OnInit {

  data: any[] = [
    { leaveType: "United States - Vacation Leave - US", period: "Wed, 01 Jan 2020 to Thu, 31 Dec 2020", days: "0.00", pendingDay: "0.00", scheduleDay: "0.00", takenDay: "0.00", availableBalanceDay: "0.00", totalOverdrawnDay: "0.00" },
    { leaveType: "United States - Casual (Deleted)", period: "Wed, 01 Jan 2020 to Thu, 31 Dec 2020", days: "0.00", pendingDay: "0.00", scheduleDay: "0.00", takenDay: "0.00", availableBalanceDay: "0.00", totalOverdrawnDay: "0.00" },
    { leaveType: "United States - Maternity Leave - US", period: "Wed, 01 Jan 2020 to Thu, 31 Dec 2020", days: "0.00", pendingDay: "0.00", scheduleDay: "0.00", takenDay: "0.00", availableBalanceDay: "0.00", totalOverdrawnDay: "0.00" },
    { leaveType: "United States - FMLA - US", period: "Wed, 01 Jan 2020 to Thu, 31 Dec 2020", days: "0.00", pendingDay: "0.00", scheduleDay: "0.00", takenDay: "0.00", availableBalanceDay: "0.00", totalOverdrawnDay: "0.00" },
  ];

  constructor() { }

  ngOnInit() {
  }

}
