import { Component, OnInit } from '@angular/core';
import { CommonService } from '../services/common.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  hide = true;

  constructor(private commonService: CommonService,
    private router: Router
  ) { }

  ngOnInit() {
    this.commonService.loginChange(false);
  }

  login() {
    this.commonService.loginChange(true);
    this.router.navigate(['dashboard']);
  }

}
