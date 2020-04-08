using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserServiceDL
    {
        SqlConnection scon;

        public UserServiceDL()
        {
            scon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["HrmsConnString"].ConnectionString);
        }
        public DataSet GetUserDetailBasedOnUserCredentials(string UserName, string Password)
        {
            try
            {
                scon.Open();
                SqlCommand command = new SqlCommand("GetUserDetailBasedOnUserCredentials", scon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserName;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (scon.State == ConnectionState.Open)
                    scon.Close();
            }
        }

        public DataSet GetUserDetailsById(long UserId)
        {
            try
            {
                scon.Open();
                SqlCommand command = new SqlCommand("GetUserDetailsById", scon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@UserId", SqlDbType.BigInt).Value = UserId;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (scon.State == ConnectionState.Open)
                    scon.Close();
            }
        }

        public DataSet GetUserRoleDetails(int RoleId)
        {
            try
            {
                scon.Open();
                SqlCommand command = new SqlCommand("GetUserRoleDetails", scon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@RoleId", SqlDbType.Int).Value = RoleId;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (scon.State == ConnectionState.Open)
                    scon.Close();
            }
        }

        public long InsertUserDetails(string UserName, string Password, int EmployeeId, List<int> RoleIds)
        {
            try
            {
                scon.Open();
                SqlCommand command = new SqlCommand("InsertUserDetails", scon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserName;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;
                command.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = EmployeeId;
                command.Parameters.Add("@Roles", SqlDbType.VarChar).Value = string.Join(",", RoleIds);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                long UserId = 0;
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    UserId = Convert.ToInt64(ds.Tables[0].Rows[0]["UserID"].ToString());
                }

                return UserId;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (scon.State == ConnectionState.Open)
                    scon.Close();
            }
        }

        public DataSet GetRoles()
        {
            try
            {
                scon.Open();
                SqlCommand command = new SqlCommand("GetRoles", scon);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (scon.State == ConnectionState.Open)
                    scon.Close();
            }
        }

        public long UpdateUserDetails(string UserName, long UserId, string Password,bool IsPasswordChange,int EmployeeId, List<int> RoleIds)
        {
            try
            {
                scon.Open();
                SqlCommand command = new SqlCommand("UpdateUserDetails", scon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserName;
                command.Parameters.Add("@UserId", SqlDbType.BigInt).Value = UserId;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;
                command.Parameters.Add("@IsPasswordChange", SqlDbType.Bit).Value = IsPasswordChange;
                command.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = EmployeeId;
                command.Parameters.Add("@Roles", SqlDbType.VarChar).Value = string.Join(",", RoleIds);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);


                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    UserId = Convert.ToInt64(ds.Tables[0].Rows[0]["UserID"].ToString());
                }

                return UserId;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (scon.State == ConnectionState.Open)
                    scon.Close();
            }
        }

        public DataSet GetRoleNamesAndTypes()
        {
            try
            {
                scon.Open();
                SqlCommand command = new SqlCommand("GetRoleNamesAndTypes", scon);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void InsertRoleDataGroupPermissions(int roleId, DataGroupPermissions dataGroupPermissions)
        {
            try
            {
                scon.Open();
                SqlCommand command = new SqlCommand("InsertRoleDataGroupPermissions", scon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@RoleId", SqlDbType.Int).Value = roleId;
                command.Parameters.Add("@DataGroupPermissionIds", SqlDbType.VarChar).Value = string.Join(",", dataGroupPermissions.AdminGroups.Select(a => a.DataGroupIdPermissionsId));

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (scon.State == ConnectionState.Open)
                    scon.Close();
            }
        }

        public void InsertRoleWorkflowManagements(int roleId, List<WorkflowManagement> workflowManagements)
        {
            try
            {
                scon.Open();
                SqlCommand command = new SqlCommand("InsertRoleWorkflowManagements", scon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@RoleId", SqlDbType.Int).Value = roleId;
                command.Parameters.Add("@WorkflowManagements", SqlDbType.VarChar).Value = string.Join(";", workflowManagements.Select(o => o.WorkflowActionId));
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (scon.State == ConnectionState.Open)
                    scon.Close();
            }
        }

        public void InsertRoleEmployeeActions(int roleId, List<EmployeeActions> employeeActions)
        {
            try
            {
                scon.Open();
                SqlCommand command = new SqlCommand("InsertRoleEmployeeActions", scon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@RoleId", SqlDbType.Int).Value = roleId;
                command.Parameters.Add("@EmployeeActions", SqlDbType.VarChar).Value = string.Join(";", employeeActions.Select(o => o.EmployeeActionId));
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (scon.State == ConnectionState.Open)
                    scon.Close();
            }
        }

        public int InsertRole(string RoleName, int RoleType)
        {
            try
            {
                scon.Open();
                SqlCommand command = new SqlCommand("InsertRole", scon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@RoleName", SqlDbType.VarChar).Value = RoleName;
                command.Parameters.Add("@RoleType", SqlDbType.Int).Value = RoleType;
                int RoleId = Convert.ToInt32(command.ExecuteScalar());
                return RoleId;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (scon.State == ConnectionState.Open)
                    scon.Close();
            }
        }
    }
}
