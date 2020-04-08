import { EmployeeActions } from './employeeActions';
import { WorkflowManagement } from './workflowManagement';

export class Roles {
    userName: string;
    roleId: number;
    roleName: string;
    roleType: number;
    roleTypeName: string;
    employeeActions: EmployeeActions[];
    workflowManagements: WorkflowManagement[];
    dataGroupPermissions: any;

    oragnizationId: number;

    constructor() {
        this.oragnizationId = 1;
    }

}