import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CustomFieldService } from './services/custom-field.service';

@Component({
  selector: 'app-custom-fields',
  templateUrl: './custom-fields.component.html',
  styleUrls: ['./custom-fields.component.scss']
})
export class CustomFieldsComponent implements OnInit {
  customSections: any;
  constructor(
    private _router: Router,
    private _service: CustomFieldService) {

  }

  ngOnInit() {
    this._getCustomSections();
  }


  add(): void {
    this._router.navigate(['pim/configuration/custom-fields/add']);
  }

  private _getCustomSections(): void {
    this._service.getCustomSections().subscribe(t => {
      this.customSections = t;
    })
  }
}
