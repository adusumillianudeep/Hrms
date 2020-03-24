import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-bradford-factor-threshold',
  templateUrl: './bradford-factor-threshold.component.html',
  styleUrls: ['./bradford-factor-threshold.component.scss']
})
export class BradfordFactorThresholdComponent implements OnInit {

  data: any[] = [
    { name: "No Action Required", threshold: '50.00' },
    { name: "Verbal Warning", threshold: '125.00' },
    { name: "First Written Warning", threshold: '400.00' },
    { name: "Final Written Warning", threshold: '650.00' },
    { name: "Termination of Contract", threshold: '800.00' },
  ];

  constructor() { }

  ngOnInit() {
  }
}
