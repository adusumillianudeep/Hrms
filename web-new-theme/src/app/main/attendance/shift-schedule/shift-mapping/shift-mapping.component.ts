import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { fuseAnimations } from '@fuse/animations';
import { startOfDay } from 'date-fns';

@Component({
  selector: 'app-shift-mapping',
  templateUrl: './shift-mapping.component.html',
  styleUrls: ['./shift-mapping.component.scss'],
  encapsulation: ViewEncapsulation.None,
  animations: fuseAnimations
})
export class ShiftMappingComponent implements OnInit {

  data: any[] = [
    { employee: "Test Employee-1", shift: "General(12am-12am) ", modifiedOn: "21-Mar-2020 05:39 PM" },
    { employee: "Test Employee-2", shift: "General(12am-12am) ", modifiedOn: "21-Mar-2020 05:39 PM" },
    { employee: "Test Employee-3", shift: "General(12am-12am) ", modifiedOn: "21-Mar-2020 05:39 PM" },
    { employee: "Test Employee-4", shift: "General(12am-12am) ", modifiedOn: "21-Mar-2020 05:39 PM" },
  ];

  constructor() {
  }

  ngOnInit() {
  }

}
