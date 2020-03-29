import { FuseNavigation } from '@fuse/types';

export const navigation: FuseNavigation[] = [
    {
        id: 'my-shortcuts',
        title: 'My Shortcuts',
        type: 'item',
        icon: 'short_text',
        url: '/dashboard',
    },
    {
        id: 'admin',
        title: 'Admin',
        type: 'collapsable',
        icon: 'account_circle',
        children: [
            {
                id: 'user-management',
                title: 'User Management',
                type: 'collapsable',
                icon: 'people_outline',
                children: [
                    {
                        id: 'users',
                        title: 'Users',
                        type: 'item',
                        url: '/admin/user-management/users'
                    },
                    {
                        id: 'user-roles',
                        title: 'User Roles',
                        type: 'item',
                        url: '/admin/user-management/user-roles'
                    }
                ]
            },
            {
                id: 'job',
                title: 'Job',
                type: 'collapsable',
                icon: 'business_center',
                children: [
                    {
                        id: 'job-titles',
                        title: 'Job Titles',
                        type: 'item',
                        url: '/admin/job/job-titles'
                    },
                    {
                        id: 'salary-components',
                        title: 'Salary Components',
                        type: 'item',
                        url: '/admin/job/salary-components'
                    },
                    {
                        id: 'pay-grades',
                        title: 'Pay Grades',
                        type: 'item',
                        url: '/admin/job/pay-grades'
                    },
                    {
                        id: 'employment-status',
                        title: 'Employment Status',
                        type: 'item',
                        url: '/admin/job/employment-status'
                    },
                    {
                        id: 'job-categories',
                        title: 'Job Categories',
                        type: 'item',
                        url: '/admin/job/job-categories'
                    },
                    {
                        id: 'work-shifts',
                        title: 'Work Shifts',
                        type: 'item',
                        url: '/admin/job/work-shifts'
                    }
                ]
            },
            {
                id: 'organization',
                title: 'Organization',
                type: 'collapsable',
                icon: 'business',
                children: [
                    {
                        id: 'general-info',
                        title: 'General Information',
                        type: 'item',
                        url: '/admin/organization/general-information'
                    },
                    {
                        id: 'locations',
                        title: 'Locations',
                        type: 'item',
                        url: '/admin/organization/locations'
                    },
                    {
                        id: 'structure',
                        title: 'Structure',
                        type: 'item',
                        url: '/error-404/1'
                    },
                    {
                        id: 'cost-centers',
                        title: 'Cost Centers',
                        type: 'item',
                        url: '/admin/organization/cost-centers'
                    },
                    {
                        id: 'process-eeo-filling',
                        title: 'Process EEO Filling',
                        type: 'item',
                        url: '/admin/organization/process-eeo-filling'
                    }
                ]
            },
            {
                id: 'competencies',
                title: 'Competencies',
                type: 'collapsable',
                icon: 'gamepad',
                children: [
                    {
                        id: 'competency-list',
                        title: 'Competency List',
                        type: 'item',
                        url: '/admin/competencies/competency-list'
                    }
                ]
            },
            {
                id: 'qualifications',
                title: 'Qualifications',
                type: 'collapsable',
                icon: 'turned_in_not',
                children: [
                    {
                        id: 'skills',
                        title: 'Skills',
                        type: 'item',
                        url: '/admin/qualifications/skills'
                    },
                    {
                        id: 'education',
                        title: 'Education',
                        type: 'item',
                        url: '/admin/qualifications/education'
                    },
                    {
                        id: 'licenses',
                        title: 'Licenses',
                        type: 'item',
                        url: '/admin/qualifications/licenses'
                    },
                    {
                        id: 'languages',
                        title: 'Languages',
                        type: 'item',
                        url: '/admin/qualifications/languages'
                    },
                    {
                        id: 'memberships',
                        title: 'Memberships',
                        type: 'item',
                        url: '/admin/qualifications/memberships'
                    }
                ]
            },
            {
                id: 'nationalities',
                title: 'Nationalities',
                type: 'item',
                icon: 'outlined_flag',
                url: '/admin/nationalities'
            },
            {
                id: 'announcements',
                title: 'Announcements',
                type: 'collapsable',
                icon: 'turned_in_not',
                children: [
                    {
                        id: 'news',
                        title: 'News',
                        type: 'item',
                        url: '/admin/announcements/news'
                    },
                    {
                        id: 'documents',
                        title: 'Documents',
                        type: 'item',
                        url: '/admin/announcements/documents'
                    },
                    {
                        id: 'document-categories',
                        title: 'Document Categories',
                        type: 'item',
                        url: '/admin/announcements/document-categories'
                    }
                ]
            },
            {
                id: 'configuration',
                title: 'Configuration',
                type: 'collapsable',
                icon: 'settings',
                children: [
                    {
                        id: 'email-settings',
                        title: 'Email Settings',
                        type: 'item',
                        url: '/admin/configuration/email-settings'
                    },
                    {
                        id: 'email-notifications',
                        title: 'Email Notifications',
                        type: 'item',
                        url: '/admin/configuration/email-notifications'
                    },
                    {
                        id: 'localization',
                        title: 'Localization',
                        type: 'item',
                        url: '/admin/configuration/localization'
                    },
                    {
                        id: 'authentication',
                        title: 'Authentication',
                        type: 'item',
                        url: '/admin/configuration/authentication'
                    },
                    {
                        id: 'directory-configuration',
                        title: 'Directory Configuration',
                        type: 'item',
                        url: '/admin/configuration/directory-configuration'
                    },
                    {
                        id: 'theme-colors',
                        title: 'Theme Colors',
                        type: 'item',
                        url: '/admin/configuration/theme-colors'
                    },
                    {
                        id: 'theme-images',
                        title: 'Theme Images',
                        type: 'item',
                        url: '/admin/configuration/theme-images'
                    }
                ]
            },
            {
                id: 'audit-trail',
                title: 'Audit Trail',
                type: 'item',
                icon: 'assignment',
                url: '/admin/audit-trail'
            },
        ]
    },
    {
        id: 'leave',
        title: 'Leave',
        type: 'collapsable',
        icon: 'account_circle',
        children: [
            {
                id: 'apply',
                title: 'Apply',
                type: 'item',
                icon: 'assignment',
                url: '/leave/apply'
            },
            {
                id: 'my-leave',
                title: 'My Leave',
                type: 'item',
                icon: 'assignment',
                url: '/leave/my-leave'
            },
            {
                id: 'leave-list',
                title: 'Leave List',
                type: 'item',
                icon: 'assignment',
                url: '/leave/leave-list'
            },
            {
                id: 'entitlements',
                title: 'Entitlements',
                type: 'collapsable',
                icon: 'people_outline',
                children: [
                    {
                        id: 'add-entitlements',
                        title: 'Add Entitlements',
                        type: 'item',
                        url: '/leave/entitlements/add-entitlements'
                    },
                    {
                        id: 'entitlements-list',
                        title: 'Entitlements List',
                        type: 'item',
                        url: '/leave/entitlements/list-entitlements'
                    },
                    {
                        id: 'my-entitlements',
                        title: 'My Entitlements',
                        type: 'item',
                        url: '/leave/entitlements/my-entitlements'
                    }
                ],
            },
            {
                id: 'report',
                title: 'Report',
                type: 'collapsable',
                icon: 'people_outline',
                children: [
                    {
                        id: 'leave-usage',
                        title: 'Leave Usage',
                        type: 'item',
                        url: '/leave/report/leave-usage'
                    },
                    {
                        id: 'my-leave-usage',
                        title: 'My Leave Usage',
                        type: 'item',
                        url: '/leave/report/myleave-usage'
                    },
                    {
                        id: 'bradford-factor',
                        title: 'Bradford Factor',
                        type: 'item',
                        url: '/leave/report/bradford-factor'
                    }
                ],
            },
            {
                id: 'configure',
                title: 'Configure',
                type: 'collapsable',
                icon: 'people_outline',
                children: [
                    {
                        id: 'leave-period',
                        title: 'Leave Period',
                        type: 'item',
                        url: '/leave/configure/leave-period'
                    },
                    {
                        id: 'leave-type',
                        title: 'Leave Type',
                        type: 'item',
                        url: '/leave/configure/leave-types'
                    },
                    {
                        id: 'work-week',
                        title: 'Work Week',
                        type: 'item',
                        url: '/leave/configure/work-week'
                    },
                    {
                        id: 'holidays',
                        title: 'Holidays',
                        type: 'item',
                        url: '/leave/configure/holidays'
                    },
                    {
                        id: 'bradford-factor-threshold',
                        title: 'Bradford Factor Threshold',
                        type: 'item',
                        url: '/leave/configure/bradford-factor-threshold'
                    },
                    {
                        id: 'working-weekends',
                        title: 'Working Weekends',
                        type: 'item',
                        url: '/leave/configure/working-weekends'
                    },
                    {
                        id: 'notifications',
                        title: 'Notifications',
                        type: 'item',
                        url: '/leave/configure/notifications'
                    }
                ],
            },
            {
                id: 'assign-leave',
                title: 'Assign Leave',
                type: 'item',
                icon: 'assignment',
                url: '/leave/assing'
            },
            {
                id: 'leave-calendar',
                title: 'Leave Calendar',
                type: 'item',
                icon: 'assignment',
                url: '/leave/calendar'
            },
            {
                id: 'bulk-assign',
                title: 'Bulk Assign',
                type: 'item',
                icon: 'assignment',
                url: '/leave/bulk-assign'
            }
        ]
    },
    {
        id: 'pim',
        title: 'PIM',
        type: 'collapsable',
        icon: 'account_circle',
        children: [
            {
                id: 'add-employee',
                title: 'Add Employee',
                type: 'item',
                icon: 'assignment',
                url: '/pim/add-employee'
            }
        ]
    },
    {
        id: 'attendance',
        title: 'Attendance',
        type: 'collapsable',
        icon: 'account_circle',
        children: [
            {
                id: 'shift-schedule',
                title: 'Shift Schedule',
                type: 'collapsable',
                icon: 'people_outline',
                children: [
                    {
                        id: 'shift',
                        title: 'Shift(s)',
                        type: 'item',
                        url: '/attendance/shift-schedule/shift-details'
                    },
                    {
                        id: 'shift-mapping',
                        title: 'Employee Shift Mapping',
                        type: 'item',
                        url: '/attendance/shift-schedule/shift-mapping'
                    }
                ]
            },
            {
                id: 'settings',
                title: 'Settings',
                type: 'collapsable',
                icon: 'people_outline',
                children: [
                    {
                        id: 'users-settings',
                        title: 'Users/Shift Sepfic Settings',
                        type: 'item',
                        url: '/attendance/settings/user-settings'
                    },
                    {
                        id: 'user-id-mapping',
                        title: 'User ID Mapping',
                        type: 'item',
                        url: '/attendance/settings/user-id-mapping'
                    },
                    {
                        id: 'absent-schedule',
                        title: 'Absent Schedule',
                        type: 'item',
                        url: '/attendance/settings/absent-schedule'
                    },
                    {
                        id: 'regularization',
                        title: 'Regularization',
                        type: 'item',
                        url: '/attendance/settings/regularization'
                    },
                    {
                        id: 'payperiod-settings',
                        title: 'Pay Period Settings',
                        type: 'item',
                        url: '/attendance/settings/payperiod-settings'
                    },
                    {
                        id: 'ip-restriction',
                        title: 'IP Restriction',
                        type: 'item',
                        url: '/attendance/settings/ip-restriction'
                    },
                    {
                        id: 'geo-restriction',
                        title: 'Geo Restriction',
                        type: 'item',
                        url: '/attendance/settings/geo-restriction'
                    }
                ],
            }
        ]
    }
];
