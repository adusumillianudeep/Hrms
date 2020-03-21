import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-bradford-factor',
  templateUrl: './bradford-factor.component.html',
  styleUrls: ['./bradford-factor.component.scss']
})
export class BradfordFactorComponent implements OnInit {

  data: any[] = [
    { employee: "Brody Alan", title: "Technical Support Manager", subUnit: "QA Team", location: "Texas R&D", days: "7.5", spell: "5", bradfordFactor: "187.5" },
    { employee: "Melan Peiris", title: "Software Engineer", subUnit: "Customization Team", location: "HQ - CA, USA", days: "7.5", spell: "5", bradfordFactor: "187.5" },
    { employee: "Linda Anderson", title: "Senior Technical Support Engineer", subUnit: "QA Team", location: "New York Sales Office", days: "7.5", spell: "5", bradfordFactor: "187.5" },
    { employee: "Pavithrra S", title: "Global HR Manager", subUnit: "Administration", location: "Texas R&D", days: "7.5", spell: "5", bradfordFactor: "187.5" },
    { employee: "Kevin Mathews", title: "Production Manager", subUnit: "IT", location: "Texas R&D", days: "7.5", spell: "5", bradfordFactor: "187.5" },
  ];

  constructor() { }

  ngOnInit() {
  }

}
