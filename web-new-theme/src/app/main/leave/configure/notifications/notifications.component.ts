import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-notifications',
  templateUrl: './notifications.component.html',
  styleUrls: ['./notifications.component.scss']
})
export class NotificationsComponent implements OnInit {

  data: any[] = [
    { name: "No Action Required", subject: 'Test' },
    { name: "Verbal Warning", subject: 'Test1' },
    { name: "First Written Warning", subject: 'Test2' },
    { name: "Final Written Warning", subject: 'Test3' },
    { name: "Termination of Contract", subject: 'Test4' },
  ];

  constructor() { }

  ngOnInit() {
  }
}
