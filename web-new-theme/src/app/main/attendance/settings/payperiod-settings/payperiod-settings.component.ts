import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-payperiod-settings',
  templateUrl: './payperiod-settings.component.html',
  styleUrls: ['./payperiod-settings.component.scss']
})
export class PayperiodSettingsComponent implements OnInit {

  data: any[] = [
    { name: "Test name - 1", payPeriodCycle: "2nd of Previous Month - 1st of Current Month", payrollprocessingDay: "1st of Current Month", applicationLocation: "All" },
    { name: "Test name - 2", payPeriodCycle: "2nd of Previous Month - 1st of Current Month", payrollprocessingDay: "1st of Current Month", applicationLocation: "All" },
  ];

  constructor() { }

  ngOnInit() {
  }

}
