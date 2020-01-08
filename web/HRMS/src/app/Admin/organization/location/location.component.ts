import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { OrganizationService } from '../organization.service';

@Component({
  selector: 'app-location',
  templateUrl: './location.component.html',
  styleUrls: ['./location.component.scss']
})
export class LocationComponent implements OnInit {

  locationForm: FormGroup;
  constructor(private organizationService: OrganizationService) { }

  ngOnInit() {
    this.locationForm = new FormGroup({
      name: new FormControl('', Validators.required),
      city: new FormControl(''),
      country: new FormControl('', Validators.required),
      address: new FormControl(''),
      postalCode: new FormControl(''),
      phone: new FormControl(''),
      fax: new FormControl(''),
      comments: new FormControl('')
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
