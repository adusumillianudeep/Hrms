using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace Hrms.Controllers.Admin
{
    [RoutePrefix("api/licenses")]
    public class LicenseController : ApiController
    {
        private readonly LicenseService _licenseService;

        public LicenseController()
        {
            _licenseService = new LicenseService();
        }

        [HttpGet]
        [Route("")]
        [ResponseType(typeof(IEnumerable<LicenseModel>))]
        public IHttpActionResult GetLicenses()
        {
            try
            {
                return Ok(_licenseService.GetLicenses());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("~/api/licensesforpage")]
        [ResponseType(typeof(IEnumerable<LicenseModel>))]
        public IHttpActionResult GetLicensesForPage(int pageNumber = 1, int itemsPerPage = 10, string sortField = "Id", string sortOrder = "DESC")
        {
            try
            {
                if (!(sortOrder == SortingService.SortByAscending || sortOrder == SortingService.SortByDescending))
                {
                    return BadRequest("Invalid sort order");
                }

                return Ok(_licenseService.GetLicensesForPage(pageNumber, itemsPerPage, sortField, sortOrder));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("{licenseId}")]
        [ResponseType(typeof(LicenseModel))]
        public IHttpActionResult GetLicense(long licenseId)
        {
            try
            {
                return Ok(_licenseService.GetLicense(licenseId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        [ResponseType(typeof(LicenseModel))]
        public IHttpActionResult SaveLicense(LicenseModel license)
        {
            try
            {
                return Ok(_licenseService.SaveLicense(license));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        [ResponseType(typeof(LicenseModel))]
        public IHttpActionResult UpdateLicense(LicenseModel license)
        {
            try
            {
                if (license.Id == null || license.Id <= 0)
                {
                    return BadRequest("Invalid license id");
                }

                return Ok(_licenseService.UpdateLicense(license));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        [Route("{licenseId}")]
        [ResponseType(typeof(LicenseModel))]
        public IHttpActionResult DeleteLicense(long licenseId)
        {
            try
            {
                return Ok(_licenseService.DeleteLicense(licenseId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("deletelicenses")]
        [ResponseType(typeof(LicenseModel))]
        public IHttpActionResult DeleteLicenses(List<long> licenseIds)
        {
            try
            {
                return Ok(_licenseService.DeleteLicenses(licenseIds));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
