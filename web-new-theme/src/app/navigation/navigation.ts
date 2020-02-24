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
        id: 'pim',
        title: 'PIM',
        type: 'collapsable',
        icon: 'account_circle',
        children: [
            {
                id: 'configuration',
                title: 'Configuration',
                type: 'collapsable',
                icon: 'people_outline',
                children: [
                    {
                        id: 'optional-fields',
                        title: 'Optional Fields',
                        type: 'item',
                        url: '/pim/configuration/optional-fields'
                    },
                    {
                        id: 'custom-fields',
                        title: 'Custom Fields',
                        type: 'item',
                        url: '/pim/configuration/custom-fields'
                    },
                    {
                        id: 'reporting-methods',
                        title: 'Reporting Methods',
                        type: 'item',
                        url: '/pim/configuration/reporting-methods'
                    },
                    {
                        id: 'add-employee-wizard',
                        title: 'Add Employee Wizard',
                        type: 'item',
                        url: '/pim/configuration/add-employee-wizard'
                    },
                    {
                        id: 'termination-reasons',
                        title: 'Termination Reasons',
                        type: 'item',
                        url: '/pim/configuration/termination-reasons'
                    },
                    {
                        id: 'document-templates',
                        title: 'Document Templates',
                        type: 'item',
                        url: '/pim/configuration/document-templates'
                    }
                ]
            },
        ]
    }

];
