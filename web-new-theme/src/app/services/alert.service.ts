import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material';

@Injectable({
  providedIn: 'root'
})
export class AlertService {

  constructor(private snackBar: MatSnackBar) { }

  public success(message: string): void {
    this.snackBar.open(message, 'OK', {
      verticalPosition: 'top',
      duration: 2000
    });
  }

  public error(message: string): void {
    this.snackBar.open(message, 'ERROR', {
      verticalPosition: 'top',
      duration: 2000,
    });
  }

}
