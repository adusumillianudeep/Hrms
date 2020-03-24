import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-my-entitlement',
  templateUrl: './my-entitlement.component.html',
  styleUrls: ['./my-entitlement.component.scss']
})
export class MyEntitlementComponent implements OnInit {

  myLeaveEntitlement: any[] = [
    { leaveType: "Casual Leave", entitlementType: 'Accrual', createdOn: "Sat, 01 Feb 2020", validFrom: "Sat, 01 Feb 2020", validTo: 'Thu, 31 Dec 2020', expired: ' ', days: '1.00' },
    { leaveType: "Casual Leave", entitlementType: 'Accrual', createdOn: "Sat, 01 Feb 2020", validFrom: "Sat, 01 Feb 2020", validTo: 'Thu, 31 Dec 2020', expired: ' ', days: '1.00' },
  ];

  constructor() { }

  ngOnInit() {
  }

}
