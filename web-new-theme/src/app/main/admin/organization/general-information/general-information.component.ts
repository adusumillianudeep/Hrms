import { Component, OnInit } from '@angular/core';
import { GeneralInfoService } from './services/general-info.service';
import { GeneralInformation } from './models/general-information';
import { AlertService } from 'app/services/alert.service';

@Component({
  selector: 'app-general-information',
  templateUrl: './general-information.component.html',
  styleUrls: ['./general-information.component.scss']
})
export class GeneralInformationComponent implements OnInit {

  generalInfo: GeneralInformation;

  constructor(private _generalInfoService: GeneralInfoService,
    private _alertService: AlertService
  ) {
    this.generalInfo = new GeneralInformation();
  }

  ngOnInit() {
    this.getGeneralInfo();
  }

  getGeneralInfo(): void {
    this._generalInfoService.getData().subscribe(res => {
      this.generalInfo = res[0];
    });
  }

  save(): void {
    this._generalInfoService.save(this.generalInfo).subscribe(res => {
      if (res) {
        this._alertService.success('General Information saved successfully');
      } else {
        this._alertService.error('Failed to save');
      }
    });
  }

}
