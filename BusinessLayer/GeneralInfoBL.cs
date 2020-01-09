using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Model;
using System.Data;

namespace BusinessLayer
{
    public class GeneralInfoBL
    {
        GeneralInfoDL InfoDL;
        public GeneralInfoBL()
        {
            InfoDL = new GeneralInfoDL();
        }
        public List<Organization> GetGeneralInfo(int Id)
        {
            try
            {
                DataSet ds = InfoDL.GetGeneralInfo(Id);
                List<Organization> organization = new List<Organization>();
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    organization = ds.Tables[0].AsEnumerable().Select(datarow => new Organization
                    {
                        OrganizationId = datarow.Field<long>("OrganizationId"),
                        TaxId = datarow.Field<string>("TaxId"),
                        Name = datarow.Field<string>("Name"),
                        RegistrationNumber = datarow.Field<string>("RegistrationNumber"),
                        Phone = datarow.Field<string>("Phone"),
                        Email = datarow.Field<string>("Email"),
                        Address = datarow.Field<string>("Address"),
                        City = datarow.Field<string>("City"),
                        State = datarow.Field<string>("State"),
                        Country = datarow.Field<string>("Country"),
                        ZipCode = datarow.Field<string>("ZipCode"),
                        Note = datarow.Field<string>("Note")

                    }).ToList();                   
                }

                return organization;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        public bool saveGeneralInfo(Organization organization)
        {
            try
            {
                InfoDL.saveGeneralInfo(organization);
                return true;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public List<OrganizationLocation> GetLocationInfo(int Id)
        {
            try
            {
                DataSet ds = InfoDL.GetLocationInfo(Id);
                List<OrganizationLocation> organization = new List<OrganizationLocation>();
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    organization = ds.Tables[0].AsEnumerable().Select(datarow => new OrganizationLocation
                    {
                        OrganizationLocationId = datarow.Field<long>("OrganizationLocationId"),
                        OrganizationId = datarow.Field<long>("OrganizationId"),
                        Name = datarow.Field<string>("Name"),
                        Phone = datarow.Field<string>("Phone"),
                        Address = datarow.Field<string>("Address"),
                        City = datarow.Field<string>("City"),
                        Fax = datarow.Field<string>("Fax"),
                        Country = datarow.Field<string>("Country"),
                        ZipCode = datarow.Field<string>("ZipCode"),
                        Comments = datarow.Field<string>("Comments")

                    }).ToList();
                }

                return organization;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool saveLocationInfo(OrganizationLocation location)
        {
            try
            {
                InfoDL.saveLocationInfo(location);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
