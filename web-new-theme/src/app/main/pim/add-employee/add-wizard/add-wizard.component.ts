import { Component, OnInit } from '@angular/core';
import { Validators, FormGroup, FormBuilder } from '@angular/forms';
import { MatCheckboxChange, MatDialog } from '@angular/material';

@Component({
  selector: 'app-add-wizard',
  templateUrl: './add-wizard.component.html',
  styleUrls: ['./add-wizard.component.scss']
})
export class AddWizardComponent implements OnInit {

  // Horizontal Stepper
  horizontalStepperStep1: FormGroup;
  horizontalStepperStep2: FormGroup;
  horizontalStepperStep3: FormGroup;

  constructor() { }

  ngOnInit() {
  }
}