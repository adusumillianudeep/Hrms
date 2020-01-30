using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class CostCenterDataAccess
    {
        private readonly SqlConnection _sqlConnection;

        public CostCenterDataAccess()
        {
            _sqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["HrmsConnString"].ConnectionString);
        }

        public DataSet GetCostCenters()
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand command = new SqlCommand("GetCostCenters", _sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                return ExecuteCommandAndGetDataSet(command);                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }

        public DataSet GetCostCenterById(long id)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand command = new SqlCommand("GetCostCenterById", _sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Id", SqlDbType.BigInt).Value = id;
                return ExecuteCommandAndGetDataSet(command);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }

        public long SaveCostCenter(string name, string Description)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand command = new SqlCommand("SaveCostCenter", _sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter idParameter = new SqlParameter();
                idParameter.DbType = DbType.Int64;
                idParameter.Direction = ParameterDirection.Output;

                command.Parameters.Add(idParameter);
                command.Parameters.Add("@Name", SqlDbType.VarChar, 255).Value = name;
                command.Parameters.Add("@Description", SqlDbType.VarChar, 500).Value = Description;
                command.ExecuteNonQuery();

                return Convert.ToInt64(idParameter.Value);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }

        public long UpdateCostCenter(long id, string name, string Description)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand command = new SqlCommand("UpdateCostCenter", _sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@Id", SqlDbType.BigInt).Value = id;
                command.Parameters.Add("@Name", SqlDbType.VarChar, 255).Value = name;
                command.Parameters.Add("@Description", SqlDbType.VarChar, 500).Value = Description;
                command.ExecuteNonQuery();

                return id;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }

        public long DeleteCostCenter(long id)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand command = new SqlCommand("DeleteCostCenter", _sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@Id", SqlDbType.BigInt).Value = id;
                command.ExecuteNonQuery();

                return id;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }

        public List<long> DeleteCostCenters(List<long> ids)
        {
            try
            {
                _sqlConnection.Open();
                SqlParameter parameter = new SqlParameter("@Id", ids);
                parameter.SqlDbType = SqlDbType.Structured;
                parameter.TypeName = "dbo.IntegerTableType";
                SqlCommand command = new SqlCommand("DeleteCostCenter", _sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(parameter);
                command.ExecuteNonQuery();

                return ids;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }

        private DataSet ExecuteCommandAndGetDataSet(SqlCommand sqlCommand)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }
    }
}
