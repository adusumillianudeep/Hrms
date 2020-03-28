import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-shift-details',
  templateUrl: './shift-details.component.html',
  styleUrls: ['./shift-details.component.scss']
})
export class ShiftDetailsComponent implements OnInit {

  data: any[] = [
    { shiftName: "General - 1", time: "12 : 00 AM-12 : 00 AM" },
    { shiftName: "General - 2", time: "12 : 00 AM-12 : 00 AM" },
  ];

  constructor() { }

  ngOnInit() {
  }

}
