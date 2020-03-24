import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-leave-types',
  templateUrl: './leave-types.component.html',
  styleUrls: ['./leave-types.component.scss']
})
export class LeaveTypesComponent implements OnInit {

  leaveTypes: any[] = [
    { leaveType: "Community leave AU", country: 'Australia', IsEntitlementSituational: "No", IncludedInBradfordFactorReport: "No", nominateEmployee: 'Yes'},
    { leaveType: "Compassionate & bereavement leave", country: 'Australia', IsEntitlementSituational: "No", IncludedInBradfordFactorReport: "No", nominateEmployee: 'Yes'},
    { leaveType: "Vacation Leave - Australia", country: 'Australia', IsEntitlementSituational: "No", IncludedInBradfordFactorReport: "No", nominateEmployee: 'Yes'},
    { leaveType: "Annual Leave", country: 'Australia', IsEntitlementSituational: "No", IncludedInBradfordFactorReport: "No", nominateEmployee: 'Yes'},
    { leaveType: "PTO CA", country: 'Australia', IsEntitlementSituational: "No", IncludedInBradfordFactorReport: "No", nominateEmployee: 'Yes'},
    { leaveType: "Reservist leave", country: 'Australia', IsEntitlementSituational: "No", IncludedInBradfordFactorReport: "No", nominateEmployee: 'Yes'},
    { leaveType: "Individual training leave", country: 'Australia', IsEntitlementSituational: "No", IncludedInBradfordFactorReport: "No", nominateEmployee: 'Yes'},
    { leaveType: "Medical CN", country: 'Australia', IsEntitlementSituational: "No", IncludedInBradfordFactorReport: "No", nominateEmployee: 'Yes'},
    { leaveType: "Caretaker leave FR", country: 'Australia', IsEntitlementSituational: "No", IncludedInBradfordFactorReport: "No", nominateEmployee: 'Yes'},
    { leaveType: "Sabbatical leave", country: 'Australia', IsEntitlementSituational: "No", IncludedInBradfordFactorReport: "No", nominateEmployee: 'Yes'},
    { leaveType: "Educational and study leave", country: 'Australia', IsEntitlementSituational: "No", IncludedInBradfordFactorReport: "No", nominateEmployee: 'Yes'},
    { leaveType: "Vacation DE", country: 'Australia', IsEntitlementSituational: "No", IncludedInBradfordFactorReport: "No", nominateEmployee: 'Yes'},
    { leaveType: "Compensatory leave IN", country: 'Australia', IsEntitlementSituational: "No", IncludedInBradfordFactorReport: "No", nominateEmployee: 'Yes'},
    { leaveType: "Quarantine Leave", country: 'Australia', IsEntitlementSituational: "No", IncludedInBradfordFactorReport: "No", nominateEmployee: 'Yes'},
    { leaveType: "Annual KSA", country: 'Australia', IsEntitlementSituational: "No", IncludedInBradfordFactorReport: "No", nominateEmployee: 'Yes'},
    { leaveType: "Infant care leave", country: 'United Kingdom', IsEntitlementSituational: "No", IncludedInBradfordFactorReport: "No", nominateEmployee: 'Yes'},
    { leaveType: "Sick SG", country: 'United Kingdom', IsEntitlementSituational: "No", IncludedInBradfordFactorReport: "No", nominateEmployee: 'Yes'},
    { leaveType: "Family responsibility leave", country: 'United Kingdom', IsEntitlementSituational: "No", IncludedInBradfordFactorReport: "No", nominateEmployee: 'Yes'},
    { leaveType: "Childcare UK", country: 'United Kingdom', IsEntitlementSituational: "No", IncludedInBradfordFactorReport: "No", nominateEmployee: 'Yes'},
    { leaveType: "Holiday", country: 'United Kingdom', IsEntitlementSituational: "No", IncludedInBradfordFactorReport: "No", nominateEmployee: 'Yes'},
    { leaveType: "Parental leave UK", country: 'United Kingdom', IsEntitlementSituational: "No", IncludedInBradfordFactorReport: "No", nominateEmployee: 'Yes'},
  ];

  constructor() { }

  ngOnInit() {
  }

}
