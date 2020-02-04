import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material';
import { SaveComponent } from './save/save.component';

@Component({
  selector: 'app-cost-centers',
  templateUrl: './cost-centers.component.html',
  styleUrls: ['./cost-centers.component.scss']
})
export class CostCentersComponent implements OnInit {

  costCenters: any = [];

  constructor(public _dialog: MatDialog) { }

  ngOnInit() {
  }

  save(): void {
    const dialogRef = this._dialog.open(SaveComponent, {
      width: '40%'
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }

}
