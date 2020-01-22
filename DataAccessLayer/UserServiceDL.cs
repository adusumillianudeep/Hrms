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
        public DataSet GetUserDetailBasedOnUserCredentials(string UserName,string Password)
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
    }
}
