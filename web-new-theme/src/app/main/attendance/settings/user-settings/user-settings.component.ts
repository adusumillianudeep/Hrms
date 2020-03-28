import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-user-settings',
  templateUrl: './user-settings.component.html',
  styleUrls: ['./user-settings.component.scss']
})
export class UserSettingsComponent implements OnInit {

  data: any[] = [
    { settingsName: "Test Settings", settingsType: "Shfits", totalHoursCalculation: "First Check-in & Last Check-out", inOut: "Enabled"},
    { settingsName: "Test Settings-1", settingsType: "Shfits", totalHoursCalculation: "First Check-in & Last Check-out", inOut: "Enabled"},
    { settingsName: "Test Settings-2", settingsType: "Shfits", totalHoursCalculation: "First Check-in & Last Check-out", inOut: "Enabled"},
    { settingsName: "Test Settings-3", settingsType: "Shfits", totalHoursCalculation: "First Check-in & Last Check-out", inOut: "Enabled"},
  ];

  constructor() { }

  ngOnInit() {
  }
}
