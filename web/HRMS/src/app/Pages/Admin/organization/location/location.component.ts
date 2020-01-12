import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { OrganizationService } from '../organization.service';

@Component({
  selector: 'app-location',
  templateUrl: './location.component.html',
  styleUrls: ['./location.component.scss']
})
export class LocationComponent implements OnInit {
  locationInfo:any[];
  locationForm: FormGroup;
  constructor(private organizationService: OrganizationService) { }

  ngOnInit() {
    this.locationForm = new FormGroup({
      OrganizationLocationId: new FormControl(''),
      OrganizationId: new FormControl(''),
      Name: new FormControl('', Validators.required),
      City: new FormControl(''),
      Country: new FormControl('', Validators.required),
      Address: new FormControl(''),
      ZipCode: new FormControl(''),
      Phone: new FormControl(''),
      Fax: new FormControl(''),
      Comments: new FormControl('')
    });
  }
  getLocationInfo() {
    this.organizationService.getLocationInfo(1).subscribe((data: any) => {
      this.locationInfo = data;
      this.locationForm.setValue(data[0]);
    });
  }
  saveLocationInfo() {
    const locationInfo = this.locationForm.value;
    console.log(this.locationForm.valid);
    this.organizationService.saveLocationInfo(locationInfo).subscribe(res => {
      console.log(res);
    });
  }
}
