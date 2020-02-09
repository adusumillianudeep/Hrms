using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace Hrms.Controllers.Admin
{
    [RoutePrefix("api/nationalities")]
    public class NationalityController : ApiController
    {
        private readonly NationalityService _nationalityService;

        public NationalityController()
        {
            _nationalityService = new NationalityService();
        }

        [HttpGet]
        [Route("")]
        [ResponseType(typeof(IEnumerable<NationalityModel>))]
        public IHttpActionResult GetNationalities()
        {
            try
            {
                return Ok(_nationalityService.GetNationalities());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("~/api/nationalitiesforpage")]
        [ResponseType(typeof(IEnumerable<NationalityModel>))]
        public IHttpActionResult GetNationalitiesForPage(int pageNumber = 1, int itemsPerPage = 10, string sortField = "Id", string sortOrder = "DESC")
        {
            try
            {
                if (!(sortOrder == SortingService.SortByAscending || sortOrder == SortingService.SortByDescending))
                {
                    return BadRequest("Invalid sort order");
                }

                return Ok(_nationalityService.GetNationalitiesForPage(pageNumber, itemsPerPage, sortField, sortOrder));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("{nationalityId}")]
        [ResponseType(typeof(NationalityModel))]
        public IHttpActionResult GetNationality(long nationalityId)
        {
            try
            {
                return Ok(_nationalityService.GetNationality(nationalityId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        [ResponseType(typeof(NationalityModel))]
        public IHttpActionResult SaveNationality(NationalityModel nationality)
        {
            try
            {
                return Ok(_nationalityService.SaveNationality(nationality));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        [ResponseType(typeof(NationalityModel))]
        public IHttpActionResult UpdateNationality(NationalityModel nationality)
        {
            try
            {
                if (nationality.Id == null || nationality.Id <= 0)
                {
                    return BadRequest("Invalid nationality id");
                }

                return Ok(_nationalityService.UpdateNationality(nationality));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        [Route("delete/{nationalityId}")]
        [ResponseType(typeof(NationalityModel))]
        public IHttpActionResult DeleteNationality(long nationalityId)
        {
            try
            {
                return Ok(_nationalityService.DeleteNationality(nationalityId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("deletenationalities")]
        [ResponseType(typeof(NationalityModel))]
        public IHttpActionResult DeleteNationalities(List<long> nationalityIds)
        {
            try
            {
                return Ok(_nationalityService.DeleteNationalities(nationalityIds));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
