import { Injectable } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { BehaviorSubject, Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class NavService {

  public currentUrl = new BehaviorSubject<string>(undefined);
  public onOpenCloseNav = new Subject<boolean>();
  constructor(private router: Router) {
    this.router.events.subscribe((event: any) => {
      if (event instanceof NavigationEnd) {
        this.currentUrl.next(event.urlAfterRedirects);
      }
    });
  }

  public onToggle(value: boolean) {
    this.onOpenCloseNav.next(value);
  }
}
