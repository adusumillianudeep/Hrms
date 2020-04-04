import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-add-field',
  templateUrl: './add-field.component.html',
  styleUrls: ['./add-field.component.scss']
})
export class AddFieldComponent implements OnInit {
  
  @Input()
  customSectionId:number;

  constructor() { }

  ngOnInit() {
  }

}
