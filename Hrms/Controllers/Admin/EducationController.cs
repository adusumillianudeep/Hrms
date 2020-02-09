using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace Hrms.Controllers.Admin
{
    [RoutePrefix("api/educations")]
    public class EducationController : ApiController
    {
        private readonly EducationService _educationService;

        public EducationController()
        {
            _educationService = new EducationService();
        }

        [HttpGet]
        [Route("")]
        [ResponseType(typeof(IEnumerable<EducationModel>))]
        public IHttpActionResult GetEducations()
        {
            try
            {
                return Ok(_educationService.GetEducations());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("~/api/educationsforpage")]
        [ResponseType(typeof(IEnumerable<EducationModel>))]
        public IHttpActionResult GetEducationsForPage(int pageNumber = 1, int itemsPerPage = 10, string sortField = "Id", string sortOrder = "DESC")
        {
            try
            {
                if (!(sortOrder == SortingService.SortByAscending || sortOrder == SortingService.SortByDescending))
                {
                    return BadRequest("Invalid sort order");
                }

                return Ok(_educationService.GetEducationsForPage(pageNumber, itemsPerPage, sortField, sortOrder));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("{educationId}")]
        [ResponseType(typeof(EducationModel))]
        public IHttpActionResult GetEducation(long educationId)
        {
            try
            {
                return Ok(_educationService.GetEducation(educationId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        [ResponseType(typeof(EducationModel))]
        public IHttpActionResult SaveEducation(EducationModel education)
        {
            try
            {
                return Ok(_educationService.SaveEducation(education));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        [ResponseType(typeof(EducationModel))]
        public IHttpActionResult UpdateEducation(EducationModel education)
        {
            try
            {
                if (education.Id == null || education.Id <= 0)
                {
                    return BadRequest("Invalid education id");
                }

                return Ok(_educationService.UpdateEducation(education));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        [Route("{educationId}")]
        [ResponseType(typeof(EducationModel))]
        public IHttpActionResult DeleteEducation(long educationId)
        {
            try
            {
                return Ok(_educationService.DeleteEducation(educationId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("deleteeducations")]
        [ResponseType(typeof(EducationModel))]
        public IHttpActionResult DeleteEducations(List<long> educationIds)
        {
            try
            {
                return Ok(_educationService.DeleteEducations(educationIds));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
