using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer;
using Model;

namespace Hrms.Controllers.Admin
{
    public class UserController : ApiController
    {
        readonly UserServiceBL userServiceBL;
        public UserController()
        {
            userServiceBL = new UserServiceBL();
        }

        /// <summary>
        /// Fetch user details by userid
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        [HttpGet]
        public Users GetUserDetailsById(long UserId)
        {
            try
            {
                return userServiceBL.GetUserDetailsById(UserId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// fetch roled details by roleid
        /// </summary>
        /// <param name="RoleId"></param>
        /// <returns></returns>
        [HttpGet]
        public List<Roles> GetUserRoleDetails(int RoleId)
        {
            try
            {
                return userServiceBL.GetUserRoleDetails(RoleId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Save userdetails
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        [HttpPost]
        public long InsertUserDetails(Users users)
        {
            try
            {
                return userServiceBL.InsertUserDetails(users);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Update userdetails
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        [HttpPost]
        public long UpdateUserDetails(Users users)
        {
            try
            {
                return userServiceBL.UpdateUserDetails(users);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

}