import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { Router } from '@angular/router';
import { MatDialogRef, MatCheckboxChange } from '@angular/material';
import { fuseAnimations } from '@fuse/animations';

@Component({
  selector: 'app-add-employee-dailog',
  templateUrl: './add-employee-dailog.component.html',
  styleUrls: ['./add-employee-dailog.component.scss'],
  encapsulation: ViewEncapsulation.None,
  animations: fuseAnimations
})
export class AddEmployeeDailogComponent implements OnInit {

  isChecked: boolean;
  constructor(
    private _router: Router,
    public dialogRef: MatDialogRef<AddEmployeeDailogComponent>) { }

  ngOnInit() {
  }

  gotoWizard(): void {
    this._router.navigate(['pim/employee-list/add-wizard']);
    this.dialogRef.close();

  }

  onChange(event: MatCheckboxChange) {
    this.isChecked = event.checked;
  }
}
