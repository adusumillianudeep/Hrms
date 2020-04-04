import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatCheckboxChange } from '@angular/material';
import { SaveComponent } from './save/save.component';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.scss']
})

export class AddEmployeeComponent implements OnInit {

  isIncludeContractDetails: boolean;

  // Horizontal Stepper
  horizontalStepperStep1: FormGroup;
  horizontalStepperStep2: FormGroup;
  horizontalStepperStep3: FormGroup;

  constructor(
    private dialog: MatDialog,
    private _formBuilder: FormBuilder,
    private router: Router) { }

  ngOnInit() {
    const dialogRef = this.dialog.open(SaveComponent, {});

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });

    // Horizontal Stepper form steps
    this.horizontalStepperStep1 = this._formBuilder.group({
      firstName: ['', Validators.required],
      middleName: [''],
      lastName: [''],
      employeeId: [''],
      otherId: [''],
      dateOfBirth: [''],
      maritalStatus: [''],
      gender: [''],
      nationality: [''],
      licenseNumber: [''],
      licenseExpiryDate: [''],
      nickName: [''],
      militaryService: [''],
      smoker: [''],
      bloodGroup: [''],
      hobbies: [''],
    });

    this.horizontalStepperStep2 = this._formBuilder.group({
      joinedDate: [''],
      dateOfPermanency: [''],
      jobTitle: [''],
      employmentStatus: [''],
      jobCategory: [''],
      subUnit: [''],
      costCenter: [''],
      workShift: [''],
      effectiveFrom: [''],
      comments: [''],
      startDate: [''],
      endDate: [''],
      region: [''],
      fte: [''],
      temporaryDepartment: [''],
    });

    this.horizontalStepperStep3 = this._formBuilder.group({
      city: ['', Validators.required],
      state: ['', Validators.required],
      postalCode: ['', [Validators.required, Validators.maxLength(5)]]
    });

  }

  onChange(event: MatCheckboxChange) {
    this.isIncludeContractDetails = event.checked;
  }

  next() {
    this.router.navigateByUrl('/pim/add-employee/add-wizard');
  }
}