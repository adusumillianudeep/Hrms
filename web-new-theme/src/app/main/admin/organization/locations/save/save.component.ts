import { Component, OnInit } from '@angular/core';
import { MatDialogRef } from '@angular/material';

@Component({
  selector: 'app-save',
  templateUrl: './save.component.html',
  styleUrls: ['./save.component.scss']
})
export class SaveComponent implements OnInit {

  animals: any[] = [
    { name: 'India', sound: 'IND' },
    { name: 'Australia', sound: 'AUS' },
    { name: 'USA', sound: 'USA' },
    { name: 'UAE', sound: 'UAE' },
  ];

  constructor(public _dialogRef: MatDialogRef<SaveComponent>) { }

  ngOnInit() {
  }

}
