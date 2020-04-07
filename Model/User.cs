using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Users
    {
        public long UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public string PhoneNo { get; set; }

        public string Email { get; set; }

        public long OrganizationId { get; set; }

        public List<int> RoleIds { get; set; }

        public UserRoles userRoles { get; set; }
        public UserRegions userRegions { get; set; }
        public int EmployeeId { get; set; }

        public bool IsPasswordChange { get; set; }
    }

    public class UserRoles
    {
        public long UserRoleId { get; set; }

        public long UserId { get; set; }

        public Roles Role { get; set; }

    }

    public class UserRegions
    {
        public long UserRegionId { get; set; }

        public long UserId { get; set; }

        public Regions Region { get; set; }

    }



}


