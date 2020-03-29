import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { MatCheckboxChange } from '@angular/material/checkbox';
import { fuseAnimations } from '@fuse/animations';

@Component({
  selector: 'app-save',
  templateUrl: './save.component.html',
  styleUrls: ['./save.component.scss'],
  encapsulation: ViewEncapsulation.None,
  animations: fuseAnimations
})
export class SaveComponent implements OnInit {

  isChecked: boolean;
  constructor() {
  }

  ngOnInit() {
  }

  onChange(event: MatCheckboxChange) {
    this.isChecked = event.checked;
  }
}
