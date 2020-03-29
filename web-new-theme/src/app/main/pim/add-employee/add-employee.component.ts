import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material';
import { SaveComponent } from './save/save.component';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.scss']
})

export class AddEmployeeComponent implements OnInit {

  // Horizontal Stepper
  horizontalStepperStep1: FormGroup;
  horizontalStepperStep2: FormGroup;
  horizontalStepperStep3: FormGroup;

  constructor(
    private dialog: MatDialog,
    private _formBuilder: FormBuilder) { }

  ngOnInit() {
    const dialogRef = this.dialog.open(SaveComponent, {});

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });

    // Horizontal Stepper form steps
    this.horizontalStepperStep1 = this._formBuilder.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required]
    });

    this.horizontalStepperStep2 = this._formBuilder.group({
      address: ['', Validators.required]
    });

    this.horizontalStepperStep3 = this._formBuilder.group({
      city: ['', Validators.required],
      state: ['', Validators.required],
      postalCode: ['', [Validators.required, Validators.maxLength(5)]]
    });
  }
}