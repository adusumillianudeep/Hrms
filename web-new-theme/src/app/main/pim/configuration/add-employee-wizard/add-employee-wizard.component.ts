import { Component, OnInit } from '@angular/core';
import { ConfigurationnService } from '../services/configurationn.service';
import { AlertService } from 'app/services/alert.service';

@Component({
  selector: 'app-add-employee-wizard',
  templateUrl: './add-employee-wizard.component.html',
  styleUrls: ['./add-employee-wizard.component.scss']
})
export class AddEmployeeWizardComponent implements OnInit {

  sections: any;
  constructor(
    private _configurationService: ConfigurationnService,
    private _alertService: AlertService) { }

  ngOnInit() {
    this._configurationService.get().subscribe(t => {
      this.sections = t;
    });
  }

  save(): void {
    this._configurationService.save(this.sections).subscribe(t => {
      this._alertService.success('Updated.');
    }, () => {
      this._alertService.error('Failed to update.')
    });
  }
}
