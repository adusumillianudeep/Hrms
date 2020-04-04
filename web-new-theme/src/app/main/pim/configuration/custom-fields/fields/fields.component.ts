import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-fields',
  templateUrl: './fields.component.html',
  styleUrls: ['./fields.component.scss']
})
export class FieldsComponent implements OnInit {

  @Input()
  customSectionId: number;

  constructor() { }

  ngOnInit() {
  }

}
