import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-personal-details',
  templateUrl: './personal-details.component.html',
  styleUrls: ['./personal-details.component.scss']
})
export class PersonalDetailsComponent implements OnInit {

  section: any;
  cusomtSections: any;

  personalDetailsForm: FormGroup;
  constructor(private _formBuilder: FormBuilder) { }

  ngOnInit() {
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