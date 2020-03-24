import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-holidays',
  templateUrl: './holidays.component.html',
  styleUrls: ['./holidays.component.scss']
})
export class HolidaysComponent implements OnInit {

  leaveTypes: any[] = [
    { name: "Battle of the Boyne", date: "Sun, 12 Jul 2020", day: "Full Day", repeatsAnnually: "No", country: "United Kingdom", location: "British Development Center, Sheffield Office, London Office" },
    { name: "Boxing Day", date: "Sat, 26 Dec 2020", day: "Full Day", repeatsAnnually: "Yes", country: "United Kingdom", location: "British Development Center, Sheffield Office, London Office" },
    { name: "Christmas Day", date: "Fri, 25 Dec 2020", day: "Full Day", repeatsAnnually: "Yes", country: "United Kingdom", location: "British Development Center, Sheffield Office, London Office" },
    { name: "Easter Monday", date: "Mon, 13 Apr 2020", day: "Full Day", repeatsAnnually: "Yes", country: "United Kingdom", location: "British Development Center, Sheffield Office, London Office" },
    { name: "Good Friday", date: "Fri, 10 Apr 2020", day: "Full Day", repeatsAnnually: "Yes", country: "United Kingdom", location: "British Development Center, Sheffield Office, London Office" },
    { name: "May bank holiday", date: "Fri, 08 May 2020", day: "Full Day", repeatsAnnually: "Yes", country: "United Kingdom", location: "British Development Center, Sheffield Office, London Office" },
    { name: "New Year's Day", date: "Wed, 01 Jan 2020", day: "Full Day", repeatsAnnually: "Yes", country: "United Kingdom", location: "British Development Center, Sheffield Office, London Office" },
    { name: "Saint Patrick's Day", date: "Tue, 17 Mar 2020", day: "Full Day", repeatsAnnually: "Yes", country: "United Kingdom", location: "British Development Center, Sheffield Office, London Office" },
    { name: "Spring bank holiday", date: "Mon, 25 May 2020", day: "Full Day", repeatsAnnually: "Yes", country: "United Kingdom", location: "British Development Center, Sheffield Office, London Office" },
    { name: "Christmas Day", date: "Fri, 25 Dec 2020", day: "Full Day", repeatsAnnually: "Yes", country: "United Kingdom", location: "British Development Center, Sheffield Office, London Office" },
    { name: "Columbus Day", date: "Fri, 25 Dec 2020", day: "Full Day", repeatsAnnually: "Yes", country: "United Kingdom", location: "British Development Center, Sheffield Office, London Office" },
  ];
  constructor() { }

  ngOnInit() {
  }
}
