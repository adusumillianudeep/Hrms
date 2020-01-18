import { Component, OnInit } from '@angular/core';
import { NavService } from './services/nav.service';
import { NavItem } from './models/nav-item';
import { navigation } from './navigation';
import { CommonService } from '../services/common.service';

@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html',
  styleUrls: ['./navigation.component.scss']
})
export class NavigationComponent implements OnInit {

  isOpen: boolean = true;
  isLogin: boolean;
  navItems: NavItem[] = navigation;

  constructor(private navService: NavService,
    private commonService: CommonService) { }

  ngOnInit() {
    this.navService.onOpenCloseNav.subscribe(res => {
      this.isOpen = res;
    });

    this.commonService.OnLoginChange.subscribe(res => {
      this.isLogin = res;
    })
  }
}
