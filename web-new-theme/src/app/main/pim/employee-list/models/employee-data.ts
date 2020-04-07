export class EmployeeData {
    personalDetail: PersonalDetail;
    jobProfile: JobProfile;


    addLoginDetail: boolean;
    loginDetail: LoginDetail;

    constructor() {
        this.personalDetail = new PersonalDetail();
        this.jobProfile = new JobProfile();
        this.loginDetail = new LoginDetail();
    }
}


export class PersonalDetail {
    firstName: string;
    middleName: string;
    lastName: string;
    gender: string;
    countryId: string;
    dob: string;
    maritalStatus: string;
    licenseNumber: string;
    licenseExpiry: string;
    nickName: string;
    militaryService: string;
    smoker: boolean;
    locationId: number;
    employeeId: number;

    constructor() {
        this.firstName = '';
        this.lastName = '';
        this.middleName = '';
        this.locationId = 1;
        this.employeeId = 564;
        this.countryId = '';
        this.dob = '';
        this.maritalStatus = '';
        this.licenseNumber = '';
        this.licenseExpiry = '';
        this.nickName = '';
        this.militaryService = '';
        this.smoker = false;
    }

}

export class JobProfile {
    title: string;
    category: string;

    constructor() {
        this.title = '';
        this.category = '';

    }
}

export class LoginDetail {
    username: string;
    password: string;
    status: boolean;
    essRole: string;
    adminRole: string;
    supervisorRole: string;


    constructor() {
        this.username = '';
        this.password = '';
        this.status = false;
        this.adminRole = '';
        this.essRole = '';
        this.supervisorRole = '';
    }
}