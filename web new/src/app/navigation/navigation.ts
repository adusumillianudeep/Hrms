import { NavItem } from "./models/nav-item";

export const navigation: NavItem[] = [
    {
        displayName: "My Shortcuts",
        iconName: "short_text",
        route: "",
    },
    {
        displayName: "Admin",
        iconName: "account_circle",
        route: "",
        children: [
            {
                displayName: "User Management",
                iconName: '',
                route: "",
                children: [
                    {
                        displayName: "Users",
                        iconName: "",
                        route: "/users"
                    },
                    {
                        displayName: "User Role",
                        iconName: "",
                        route: "/user-roles",
                    },
                ]
            }
        ]
    }
];