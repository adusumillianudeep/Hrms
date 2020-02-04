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
                        url: '/error-404/4'
                    },
                    {
                        id: 'salary-components',
                        title: 'Salary Components',
                        type: 'item',
                        url: '/error-404/5'
                    },
                    {
                        id: 'pay-grades',
                        title: 'Pay Grades',
                        type: 'item',
                        url: '/error-404/6'
                    },
                    {
                        id: 'employment-status',
                        title: 'Employment Status',
                        type: 'item',
                        url: '/error-404/7'
                    },
                    {
                        id: 'job-categories',
                        title: 'Job Categories',
                        type: 'item',
                        url: '/error-404/8'
                    },
                    {
                        id: 'work-shifts',
                        title: 'Work Shifts',
                        type: 'item',
                        url: '/error-404/9'
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
        ]
    }
];
