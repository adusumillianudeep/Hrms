import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-ip-restriction',
  templateUrl: './ip-restriction.component.html',
  styleUrls: ['./ip-restriction.component.scss']
})
export class IpRestrictionComponent implements OnInit {

  data: any[] = [
    { fromIpAddress: "192.168.1.1", toIpAddress: "192.168.1.2", modules: "Attendance" },
    { fromIpAddress: "192.168.1.1", toIpAddress: "192.168.1.2", modules: "Attendance" },
  ];

  constructor() { }

  ngOnInit() {
  }

}
