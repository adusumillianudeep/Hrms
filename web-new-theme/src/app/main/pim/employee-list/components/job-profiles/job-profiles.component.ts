import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { MatCheckboxChange } from '@angular/material';

@Component({
  selector: 'app-job-profiles',
  templateUrl: './job-profiles.component.html',
  styleUrls: ['./job-profiles.component.scss']
})
export class JobProfilesComponent implements OnInit {

  section: any;
  cusomtSections: any;
  JobProfilesStepper: FormGroup;
  isIncludeContractDetails: boolean;

  constructor(private _formBuilder: FormBuilder) { }

  ngOnInit() {

    this.JobProfilesStepper = this._formBuilder.group({
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

  onChange(event: MatCheckboxChange) {
    this.isIncludeContractDetails = event.checked;
  }
}
