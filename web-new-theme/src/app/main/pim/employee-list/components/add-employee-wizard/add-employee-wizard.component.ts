import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../../services/employee.service';
import { AddEmployeeService } from '../../services/add-employee.service';
import { Router } from '@angular/router';
import { AlertService } from 'app/services/alert.service';

@Component({
  selector: 'app-add-employee-wizard',
  templateUrl: './add-employee-wizard.component.html',
  styleUrls: ['./add-employee-wizard.component.scss']
})
export class AddEmployeeWizardComponent implements OnInit {
  sections: any;
  componentMapping: any;
  constructor(
    private _router: Router,
    private _alertService: AlertService,
    private _employeeService: EmployeeService,
    private _addEmployeeService: AddEmployeeService) {

  }

  ngOnInit() {

    this._employeeService.getConfiguration().subscribe(t => {
      this.sections = t;
    });

    this.componentMapping = this._employeeService.getSectionComponentMapping();


  }

  save() {
    // this should be called only after all validation passed 
    // this button should be visible only on last step in the wizard

    const empData = this._addEmployeeService.employeeData;
    this._employeeService.save(empData).subscribe(t => {
      this._alertService.success('Saved successfuly.')
      this._router.navigate(['pim/employee-list']);
    });

  }

}
