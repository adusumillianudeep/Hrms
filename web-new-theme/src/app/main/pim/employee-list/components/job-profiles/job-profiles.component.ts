import { Component, OnInit, Input } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { MatCheckboxChange } from '@angular/material';
import { AddEmployeeService } from '../../services/add-employee.service';
import { JobProfile } from '../../models/employee-data';

@Component({
  selector: 'app-job-profiles',
  templateUrl: './job-profiles.component.html',
  styleUrls: ['./job-profiles.component.scss']
})
export class JobProfilesComponent implements OnInit {

  section: any;
  cusomtSections: any;
  addWizard: boolean = false;

  @Input()
  jobProfile: JobProfile;

  JobProfilesStepper: FormGroup;
  isIncludeContractDetails: boolean;

  constructor(
    private _formBuilder: FormBuilder,
    private _addEmployeeService: AddEmployeeService
  ) { }

  ngOnInit() {

    if (this.addWizard) {
      this.jobProfile = this._addEmployeeService.employeeData.jobProfile;
    }

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
