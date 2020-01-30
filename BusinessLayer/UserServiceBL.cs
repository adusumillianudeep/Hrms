using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserServiceBL
    {
        UserServiceDL _UserServiceDL;
        public UserServiceBL()
        {
            _UserServiceDL = new UserServiceDL();
        }

        public Users GetUserDetailBasedOnUserCredentials(string UserName, string Password)
        {
            try
            {
                DataSet ds = _UserServiceDL.GetUserDetailBasedOnUserCredentials(UserName, Password);
                Users loggedInUser = new Users();
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    loggedInUser = ds.Tables[0].AsEnumerable().Select(datarow => new Users
                    {
                        UserId = datarow.Field<long>("UserId"),
                        UserName = datarow.Field<string>("UserName"),
                        FirstName = datarow.Field<string>("FirstName"),
                        LastName = datarow.Field<string>("LastName"),
                        PhoneNo = datarow.Field<string>("PhoneNo"),
                        Email = datarow.Field<string>("PhoneNo"),
                        OrganizationId = datarow.Field<long>("OrganizationId"),
                        userRoles = new UserRoles() { Role = new Roles() { RoleId = datarow.Field<int>("RoleId"), RoleName = datarow.Field<string>("RoleName") }, UserId = datarow.Field<long>("UserId") }
                    }).ToList()[0];
                }

                return loggedInUser;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Users GetUserDetailsById(long UserId)
        {
            try
            {
                DataSet ds = _UserServiceDL.GetUserDetailsById(UserId);
                Users loggedInUser = new Users();
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    loggedInUser = ds.Tables[0].AsEnumerable().Select(datarow => new Users
                    {
                        UserId = datarow.Field<long>("UserId"),
                        UserName = datarow.Field<string>("UserName"),
                        FirstName = datarow.Field<string>("FirstName"),
                        LastName = datarow.Field<string>("LastName"),
                        PhoneNo = datarow.Field<string>("PhoneNo"),
                        Email = datarow.Field<string>("PhoneNo"),
                        OrganizationId = datarow.Field<long>("OrganizationId"),
                        userRegions = new UserRegions()
                        {
                            UserId = datarow.Field<long>("UserId"),
                            Region = new Regions() { RegionId = datarow.Field<int>("RegionId"), RegionName = datarow.Field<string>("RegionName") }
                        },
                        userRoles = new UserRoles()
                        {
                            UserId = datarow.Field<long>("UserId"),
                            Role = new Roles() { RoleId = datarow.Field<int>("RoleId"), RoleName = datarow.Field<string>("RoleName") }
                        }
                    }).ToList()[0];
                }

                return loggedInUser;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Roles> GetUserRoleDetails(int RoleId)
        {
            try
            {
                DataSet ds = _UserServiceDL.GetUserRoleDetails(RoleId);
                List<Roles> roles = new List<Roles>();
                List<EmployeeActions> employeeActions = new List<EmployeeActions>();
                List<WorkflowManagement> workflowManagements = new List<WorkflowManagement>();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables.Count > 1 && ds.Tables[1].Rows.Count > 0)
                    {
                        employeeActions = ds.Tables[1].AsEnumerable().Select(datarow => new EmployeeActions
                        {
                            EmployeeActionId = datarow.Field<int>("EmployeeActionId"),
                            EmployeeActionName = datarow.Field<string>("EmployeeActionName"),
                        }).Distinct().ToList();
                    }

                    if (ds.Tables.Count > 2 && ds.Tables[2].Rows.Count > 0)
                    {
                        workflowManagements = ds.Tables[2].AsEnumerable().Select(datarow => new WorkflowManagement
                        {
                            WorkflowActionId = datarow.Field<int>("WorkflowActionId"),
                            ActionName = datarow.Field<string>("ActionName"),
                        }).Distinct().ToList();
                    }

                    roles = ds.Tables[0].AsEnumerable().Select(datarow => new Roles
                    {
                        RoleId = datarow.Field<int>("RoleId"),
                        RoleName = datarow.Field<string>("RoleName"),
                        EmployeeActions = employeeActions,
                        WorkflowManagements = workflowManagements
                    }).Distinct().ToList();
                }

                return roles;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public long InsertUserDetails(Users users)
        {
            try
            {
                return _UserServiceDL.InsertUserDetails(users.UserName, users.Password, users.FirstName, users.LastName, users.PhoneNo, users.Email, users.userRoles.Role.RoleId, users.userRegions.Region.RegionId,users.OrganizationId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public long UpdateUserDetails(Users users)
        {
            try
            {
                return _UserServiceDL.UpdateUserDetails(users.UserName, users.UserId, users.FirstName, users.LastName, users.PhoneNo, users.Email, users.userRoles.Role.RoleId, users.userRegions.Region.RegionId, users.OrganizationId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void GetRoleNamesAndTypes()
        {

        }
    }
}
