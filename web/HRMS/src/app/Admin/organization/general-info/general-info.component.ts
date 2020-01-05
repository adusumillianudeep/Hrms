import { Component, OnInit } from '@angular/core';
import { OrganizationService } from '../organization.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-general-info',
  templateUrl: './general-info.component.html',
  styleUrls: ['./general-info.component.scss']
})
export class GeneralInfoComponent implements OnInit {

  constructor(private organizationService: OrganizationService) { }
  cols: any[];
  OrganizationInfo: any[];
  generalInfoForm: FormGroup;
  ngOnInit() {
    this.generalInfoForm = new FormGroup({
      Name: new FormControl('', Validators.required),
      TaxId: new FormControl(''),
      Phone: new FormControl('', Validators.required),
      Email: new FormControl('', [Validators.pattern('[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}$')]),
      OrganizationId: new FormControl(''),
      RegistrationNumber: new FormControl(''),
      Address: new FormControl(''),
      City: new FormControl(''),
      State: new FormControl(''),
      ZipCode: new FormControl(''),
      Country: new FormControl(''),
      Note: new FormControl(''),
    });
  }

  getGeneralInfo() {
   this.organizationService.getGeneralInfo(1).subscribe((data: any) => {
      this.OrganizationInfo = data;
      this.generalInfoForm.setValue(data[0]);
    });
  }

  saveGeneralInfo() {
    const generalInfo = this.generalInfoForm.value;
    console.log(this.generalInfoForm.valid);
    this.organizationService.saveGeneralInfo(generalInfo).subscribe(res => {
      console.log(res);
    });
  }
}
