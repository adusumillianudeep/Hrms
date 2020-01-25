using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Model;

namespace DataAccessLayer
{
    public class GeneralInfoDL
    {
        SqlConnection scon;
        
        public GeneralInfoDL()
        {
            scon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["HrmsConnString"].ConnectionString);
        }
        public DataSet GetGeneralInfo(int id)
        {
            try
            {
                scon.Open();
                SqlCommand command = new SqlCommand("GetGeneralInfo",scon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@OrganizationId", SqlDbType.BigInt).Value = id;
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

        public bool saveGeneralInfo(Organization organization)
        {
            try
            {
                scon.Open();
                SqlCommand command = new SqlCommand("SaveGeneralInfo", scon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@OrganizationId", SqlDbType.BigInt).Value = organization.OrganizationId;
                command.Parameters.Add("@Name", SqlDbType.VarChar).Value = organization.Name;
                command.Parameters.Add("@TaxId", SqlDbType.VarChar).Value = organization.TaxId;
                command.Parameters.Add("@RegistrationNumber", SqlDbType.VarChar).Value = organization.RegistrationNumber;
                command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = organization.Phone;
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = organization.Email;
                command.Parameters.Add("@Address1", SqlDbType.VarChar).Value = organization.Address1;
                command.Parameters.Add("@City", SqlDbType.VarChar).Value = organization.City;
                command.Parameters.Add("@State", SqlDbType.VarChar).Value = organization.State;
                command.Parameters.Add("@ZipCode", SqlDbType.VarChar).Value = organization.ZipCode;
                command.Parameters.Add("@Country", SqlDbType.VarChar).Value = organization.Country;
                command.Parameters.Add("@Note", SqlDbType.VarChar).Value = organization.Note;
                command.Parameters.Add("@Address2", SqlDbType.VarChar).Value = organization.Address2;
                command.Parameters.Add("@NoOfEmployees", SqlDbType.Int).Value = organization.NoOfEmployees;
                command.Parameters.Add("@IsEEOEnabled", SqlDbType.Bit).Value = organization.IsEEOEnabled;
                command.Parameters.Add("@IsCostCenterEnabled", SqlDbType.Bit).Value = organization.IsCostCenterEnabled;
                command.Parameters.Add("@CostCenter", SqlDbType.VarChar).Value = organization.CostCenter;
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (scon.State == ConnectionState.Open)
                    scon.Close();
            }
        }

        public DataSet GetLocationInfo(int id)
        {
            try
            {
                scon.Open();
                SqlCommand command = new SqlCommand("GetLocationInfo", scon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@OrganizationId", SqlDbType.BigInt).Value = id;
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

        public bool saveLocationInfo(OrganizationLocation location)
        {
            try
            {
                scon.Open();
                SqlCommand command = new SqlCommand("SaveLocationInfo", scon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@OrganizationId", SqlDbType.BigInt).Value = location.OrganizationId;
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = location.Name;
                command.Parameters.Add("@City", SqlDbType.NVarChar).Value = location.City;
                command.Parameters.Add("@Country", SqlDbType.NVarChar).Value = location.Country;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = location.Address;
                command.Parameters.Add("@ZipCode", SqlDbType.NVarChar).Value = location.ZipCode;
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = location.Phone;
                command.Parameters.Add("@Fax", SqlDbType.NVarChar).Value = location.Fax;
                command.Parameters.Add("@Comments", SqlDbType.NVarChar).Value = location.Comments;
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
