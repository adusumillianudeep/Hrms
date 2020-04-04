import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material';

import { AddMemberShipsComponent } from './add-member-ships/add-member-ships.component';

@Component({
  selector: 'app-member-ships',
  templateUrl: './member-ships.component.html',
  styleUrls: ['./member-ships.component.scss']
})
export class MemberShipsComponent implements OnInit {

  data: any[] = [
    { membership: "Anudeep01", subscriptionPaidBy: 'Admin', subscriptionAmount: "Anudeep", currency: "Enabled", subscriptionCommenceDate: "Wed, 29 Apr 2020", subscriptionRenewalDate: "Thu, 30 Apr 2020" }
  ];

  constructor(private dialog: MatDialog) { }

  ngOnInit() {

  }

  add() {
    const dialogRef = this.dialog.open(AddMemberShipsComponent, {
      width: '50%'
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }
}
