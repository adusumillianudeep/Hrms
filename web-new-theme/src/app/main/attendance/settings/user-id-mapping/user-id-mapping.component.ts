import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-user-id-mapping',
  templateUrl: './user-id-mapping.component.html',
  styleUrls: ['./user-id-mapping.component.scss']
})
export class UserIdMappingComponent implements OnInit {

  data: any[] = [
    { employee: "Test Employee-1", mappingID: "121" },
    { employee: "Test Employee-2", mappingID: "122" },
    { employee: "Test Employee-2", mappingID: "123" },
    { employee: "Test Employee-2", mappingID: "124" },
  ];

  constructor() { }

  ngOnInit() {
  }

}
