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
                DataSet ds = _UserServiceDL.GetUserDetailBasedOnUserCredentials(UserName,Password);
                Users loggedInUser = new Users();
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    loggedInUser = ds.Tables[0].AsEnumerable().Select(datarow => new Users
                    {
                        Userid = datarow.Field<long>("Userid"),
                        Username = datarow.Field<string>("Username"),
                        DOB = datarow.Field<string>("DOB"),
                        Phoneno = datarow.Field<string>("Phoneno"),
                        Useremail = datarow.Field<string>("Useremail")
                    }).ToList()[0];
                }

                return loggedInUser;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
