using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class GeneralInfoDL
    {
        SqlConnection scon = new SqlConnection("Data Source=ANUDEEP;Initial Catalog=Hrms;Integrated Security=True");
        public DataSet GetGeneralInfo()
        {
            try
            {
                scon.Open();
                SqlCommand command = new SqlCommand("GetGeneralInfo",scon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@OrganizationId", SqlDbType.BigInt).Value = 1;
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
    }
}
