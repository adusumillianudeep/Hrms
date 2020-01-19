import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CommonService {

  public OnLoginChange = new Subject<boolean>();

  constructor() { }

  loginChange(value: boolean) {
    this.OnLoginChange.next(value);
  }
}
