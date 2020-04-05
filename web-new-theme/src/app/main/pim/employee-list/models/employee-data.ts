export class EmployeeData {
    personalDetail: PersonalDetail;
    jobProfile: JobProfile;

    loginDetail: LoginDetail;

    constructor(){
        this.personalDetail = new PersonalDetail();
        this.jobProfile = new JobProfile();
        this.loginDetail = new LoginDetail();
    }
}


export class PersonalDetail {
    firstName:string;
    lastName:string;
    middleName:string;
    locationId:number;
    employeeId: number;

    constructor(){
        this.firstName = '';
        this.lastName = '';
        this.middleName = '';
        this.locationId = 0;
        this.employeeId = 564;
    }

}

export class JobProfile {
    title:string;
    category:string;  

    constructor(){
        this.title = '';
        this.category = '';
        
    }
}

export class LoginDetail {
    username:string;
    password:string;
    enabled:boolean;
    essRole:string;
    adminRole:string;
    supervisorRole:string;


    constructor(){
        this.username = '';
        this.password = '';
        this.enabled = false;
        this.adminRole = '';
        this.essRole = '';
        this.supervisorRole = '';
    }
}