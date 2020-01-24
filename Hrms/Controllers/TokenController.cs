using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer;
using Model;
using Hrms.Authentication;

namespace Hrms.Controllers
{
    public class TokenController : ApiController
    {
        [HttpGet]
        [AllowAnonymous]
        public object GetTokenBasedonCredentials(string UserName, string Password)
        {
            try
            {
                UserServiceBL userServiceBL = new UserServiceBL();
                Users users = userServiceBL.GetUserDetailBasedOnUserCredentials(UserName, Password);
                if (users == null || users.UserName == null)
                {
                    return new { errormessage = "Invalid credentials provided" };
                }
                else
                {
                    var JwtToken = JwtManager.GenerateToken(users);
                    return new { username = UserName, roleid = users.userRoles.Role.RoleId, rolename = users.userRoles.Role.RoleName, token = JwtToken };
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
