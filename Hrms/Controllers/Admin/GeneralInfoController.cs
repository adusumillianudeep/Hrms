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
    public class GeneralInfoController : ApiController
    {
        GeneralInfoBL InfoBL;
        public GeneralInfoController()
        {
            InfoBL = new GeneralInfoBL();
        }

        [HttpGet]
        public List<Organization> GetGeneralInfo(int Id)
        {
            try
            {
                List<Organization> organizations = InfoBL.GetGeneralInfo(Id);
                return organizations;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        public bool SaveGeneralInfo(Organization organization)
        {
            try
            {
                InfoBL.saveGeneralInfo(organization);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        [HttpGet]
        public List<OrganizationLocation> GetLocationInfo(int Id)
        {
            try
            {
                List<OrganizationLocation> organizations = InfoBL.GetLocationInfo(Id);
                return organizations;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        public bool SaveLocationInfo(OrganizationLocation location)
        {
            try
            {
                InfoBL.saveLocationInfo(location);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}