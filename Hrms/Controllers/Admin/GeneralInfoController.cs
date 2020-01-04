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
        public List<Organization> GetGeneralInfo()
        {
            try
            {
                List<Organization> organizations = InfoBL.GetGeneralInfo();
                return organizations;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}