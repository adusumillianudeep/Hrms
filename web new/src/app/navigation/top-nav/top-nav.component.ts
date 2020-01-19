import { Component, OnInit } from '@angular/core';
import { NavService } from '../services/nav.service';

@Component({
  selector: 'app-top-nav',
  templateUrl: './top-nav.component.html',
  styleUrls: ['./top-nav.component.scss']
})
export class TopNavComponent implements OnInit {

  constructor(public navService: NavService) { }
  test = true;
  DashboardTitle:any;
  ngOnInit() { 
    this.DashboardTitle="Dashboard";
  }

  toggleClick() {
    this.test = !this.test;
    this.navService.onToggle(this.test);

  }

}
