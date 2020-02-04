import { Component, OnInit } from '@angular/core';
import { MatDialogRef } from '@angular/material';

@Component({
  selector: 'app-save',
  templateUrl: './save.component.html',
  styleUrls: ['./save.component.scss']
})
export class SaveComponent implements OnInit {

  constructor(public _dialogRef: MatDialogRef<SaveComponent>) { }

  ngOnInit() {
  }

}
