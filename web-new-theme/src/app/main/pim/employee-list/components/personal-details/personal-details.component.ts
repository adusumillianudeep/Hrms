import { Component, OnInit, Input } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { AddEmployeeService } from '../../services/add-employee.service';
import { PersonalDetail } from '../../models/employee-data';

@Component({
  selector: 'app-personal-details',
  templateUrl: './personal-details.component.html',
  styleUrls: ['./personal-details.component.scss']
})
export class PersonalDetailsComponent implements OnInit {

  section: any;
  cusomtSections: any;
  addWizard: boolean = false;

  @Input()
  personalDetail: PersonalDetail;

  personalDetailsForm: FormGroup;
  constructor(
    private _formBuilder: FormBuilder,
    private _addEmployeeService: AddEmployeeService
  ) {
  }

  ngOnInit() {
    if (this.addWizard) {
      this.personalDetail = this._addEmployeeService.employeeData.personalDetail;
    }

    this.personalDetailsForm = this._formBuilder.group({
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
  }
}