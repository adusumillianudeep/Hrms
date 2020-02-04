import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-save',
  templateUrl: './save.component.html',
  styleUrls: ['./save.component.scss']
})
export class SaveComponent implements OnInit {

  type: string = 'admin';

  constructor() { }

  ngOnInit() {
  }

  onTypeChange(type: string): void {
    debugger;
    this.type = type;
  }

}
