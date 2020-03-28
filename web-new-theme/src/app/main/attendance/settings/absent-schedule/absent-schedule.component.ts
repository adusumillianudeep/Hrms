import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-absent-schedule',
  templateUrl: './absent-schedule.component.html',
  styleUrls: ['./absent-schedule.component.scss']
})
export class AbsentScheduleComponent implements OnInit {

  data: any[] = [
    { scheduleName: "Test name - 1", timeofSchedule: "00:00 AM", attendanceDate: "Before 1 day" },
    { scheduleName: "Test name - 2", timeofSchedule: "00:00 AM", attendanceDate: "Before 1 day" },
    { scheduleName: "Test name - 3", timeofSchedule: "00:00 AM", attendanceDate: "Before 1 day" },
    { scheduleName: "Test name - 4", timeofSchedule: "00:00 AM", attendanceDate: "Before 1 day" },
    { scheduleName: "Test name - 5", timeofSchedule: "00:00 AM", attendanceDate: "Before 1 day" }
  ];

  constructor() { }

  ngOnInit() {
  }

}
