import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material';
import { SaveComponent } from './save/save.component';

@Component({
  selector: 'app-locations',
  templateUrl: './locations.component.html',
  styleUrls: ['./locations.component.scss']
})
export class LocationsComponent implements OnInit {


  locations: Location[] = [
    { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' },
    { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' },
    { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' },
    { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' },
    { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' },
    { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' },
    { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' },
    { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' },
    { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' },
    { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' },
    { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' },
    { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' },
    { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' },
    { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' },
    { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' },
    { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' },
    { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' },
    { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' },
    { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' }, { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' },
    { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' },
    { name: "Australian Regional HQ", city: 'Sydney', country: "Australia", phone: "	+61 1987 654 321", employees: 5, eeo: 'NO' },

  ];

  constructor(public _dialog: MatDialog) { }

  ngOnInit() {
  }

  save(): void {
    const dialogRef = this._dialog.open(SaveComponent, {
      width: '60%'
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }

}

export interface Location {
  name: string;
  city: string;
  country: string;
  phone: string;
  employees: number;
  eeo: string
}


