import { Component, OnInit } from '@angular/core';
import { OrganizationService } from '../organization.service';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-general-info',
  templateUrl: './general-info.component.html',
  styleUrls: ['./general-info.component.scss']
})
export class GeneralInfoComponent implements OnInit {

  constructor(private organizationService: OrganizationService) { }
  cols: any[];
  OrganizationInfo:any[];
  GeneralInfoForm:FormGroup;
  ngOnInit() {
    this.GeneralInfoForm = new FormGroup({
      
      Name: new FormControl(''),
      TaxId: new FormControl(''),
      Phone: new FormControl(''),
      Email: new FormControl(''),
      OrganizationId: new FormControl(''),
      RegistrationNumber: new FormControl(''),
      Address: new FormControl(''),
      City: new FormControl(''),
      State: new FormControl(''),
      ZipCode: new FormControl(''),
      Country: new FormControl(''),
      Note: new FormControl(''),
    });
    
    this.GetGeneralInfo();
  }
  GetGeneralInfo() {
    
    var data = this.organizationService.GetGeneralInfo().subscribe((data: any) => {
      this.OrganizationInfo = data;
      this.GeneralInfoForm.setValue(data[0]);
    });
  }
}
