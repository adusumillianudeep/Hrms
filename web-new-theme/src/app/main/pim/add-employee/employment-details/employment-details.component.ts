import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-employment-details',
  templateUrl: './employment-details.component.html',
  styleUrls: ['./employment-details.component.scss']
})
export class EmploymentDetailsComponent implements OnInit {

  horizontalStepperStep2: FormGroup;

  constructor(private _formBuilder: FormBuilder) { }

  ngOnInit() {

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
  }
}
