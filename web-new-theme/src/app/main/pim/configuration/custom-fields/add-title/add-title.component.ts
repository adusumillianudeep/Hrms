import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { CustomSection } from '../models/custom-section';
import { CustomFieldService } from '../services/custom-field.service';

@Component({
  selector: 'app-add-title',
  templateUrl: './add-title.component.html',
  styleUrls: ['./add-title.component.scss']
})
export class AddTitleComponent implements OnInit {
  customSection: CustomSection;
  @Output()
  customSectionCreated: EventEmitter<number>
  constructor(private _service: CustomFieldService) {
    this.customSectionCreated = new EventEmitter<number>();
  }

  ngOnInit() {
    this.customSection = new CustomSection();
  }


  save(): void {
    this._service.saveTitle(this.customSection).subscribe(t => {
      this.customSectionCreated.emit(t);
    })
  }
}
