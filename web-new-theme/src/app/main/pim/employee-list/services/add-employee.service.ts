import { Injectable } from '@angular/core';
import { EmployeeData } from '../models/employee-data';

@Injectable({
  providedIn: 'root'
})
export class AddEmployeeService {
  employeeData: EmployeeData;
  constructor() { }
}
