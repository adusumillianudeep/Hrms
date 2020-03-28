import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-regularization',
  templateUrl: './regularization.component.html',
  styleUrls: ['./regularization.component.scss']
})
export class RegularizationComponent implements OnInit {

  data: any[] = [
    { name: "Test Attendance", templateName: "Your request has been approved" }
  ];

  constructor() { }

  ngOnInit() {
  }

}
