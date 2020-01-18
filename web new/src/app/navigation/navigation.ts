import { NavItem } from "./models/nav-item";

export const navigation: NavItem[] = [
    {
        displayName: "My Shortcuts",
        iconName: "short_text",
        route: "devfestfl",
    },
    {
        displayName: "Admin",
        iconName: "account_circle",
        route: "devfestfl",
        children: [
            {
                displayName: "User Management",
                iconName: '',
                route: "devfestfl/speakers",
                children: [
                    {
                        displayName: "Users",
                        iconName: "",
                        route: "devfestfl/speakers/michael-prentice"
                    },
                    {
                        displayName: "Users Role",
                        iconName: "",
                        route: "devfestfl/speakers/stephen-fluin",
                    },
                ]
            }
        ]
    }
];