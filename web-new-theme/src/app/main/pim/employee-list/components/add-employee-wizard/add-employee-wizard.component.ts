import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../../services/employee.service';

@Component({
  selector: 'app-add-employee-wizard',
  templateUrl: './add-employee-wizard.component.html',
  styleUrls: ['./add-employee-wizard.component.scss']
})
export class AddEmployeeWizardComponent implements OnInit {
  sections: any;
  componentMapping: any;
  constructor(private _employeeService: EmployeeService) {

  }

  ngOnInit() {

    this._employeeService.getConfiguration().subscribe(t => {
      this.sections = t;
    });

    this.componentMapping = this._employeeService.getSectionComponentMapping();


  }

}
