import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-direct-deposit',
  templateUrl: './direct-deposit.component.html',
  styleUrls: ['./direct-deposit.component.scss']
})
export class DirectDepositComponent implements OnInit {

  data: any[] = [
    { amount: "100", accountNumber: '100', financialInstitution: "Test", accountType: "Saving", branchLocation: "Test", routingNumber: "Test" }
  ];

  constructor() { }

  ngOnInit() {
  }

}
