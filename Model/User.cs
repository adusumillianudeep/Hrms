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
        public long Userid { get; set; }

        public string Username { get; set; }

        public string Useremail { get; set; }

        public string Phoneno { get; set; }

        public string DOB { get; set; }

        public string[] Roles { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public object RoleId { get; set; }
    }
}

    
