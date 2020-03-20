using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace Hrms.Controllers
{
    [RoutePrefix("api/employmentstatus")]
    public class EmploymentStatusController : ApiController
    {
        private readonly EmploymentStatusService _employmentStatusService;

        public EmploymentStatusController()
        {
            _employmentStatusService = new EmploymentStatusService();
        }

        [HttpGet]
        [Route("GetEmploymentStatusList")]
        [ResponseType(typeof(IEnumerable<EmploymentStatusModel>))]
        public IHttpActionResult GetEmploymentStatusList()
        {
            try
            {
                return Ok(_employmentStatusService.GetEmploymentStatusList());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("GetEmploymentStatusById")]
        [ResponseType(typeof(IEnumerable<EmploymentStatusModel>))]
        public IHttpActionResult GetEmploymentStatusById(long employmentStatusId)
        {
            try
            {
                return Ok(_employmentStatusService.GetEmploymentStatusById(employmentStatusId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("SaveEmploymentStatus")]
        [ResponseType(typeof(EmploymentStatusModel))]
        public IHttpActionResult SaveEmploymentStatus(EmploymentStatusModel employmentStatus)
        {
            try
            {
                return Ok(_employmentStatusService.SaveEmploymentStatus(employmentStatus));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        [HttpPut]
        [Route("UpdateEmploymentStatus")]
        [ResponseType(typeof(EmploymentStatusModel))]
        public IHttpActionResult UpdateEmploymentStatus(EmploymentStatusModel employmentStatusModel)
        {
            try
            {
                if (employmentStatusModel.EmploymentStatusId <= 0)
                {
                    return BadRequest("Invalid EmploymentStatus id");
                }

                return Ok(_employmentStatusService.UpdateEmploymentStatus(employmentStatusModel));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        [Route("delete/{employmentStatusId}")]
        [ResponseType(typeof(EmploymentStatusModel))]
        public IHttpActionResult DeleteEmploymentStatus(long employmentStatusId)
        {
            try
            {
                return Ok(_employmentStatusService.DeleteEmploymentStatus(employmentStatusId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("DeleteEmploymentStatusList")]
        [ResponseType(typeof(EmploymentStatusModel))]
        public IHttpActionResult DeleteEmploymentStatusList(List<long> employmentStatusIds)
        {
            try
            {
                return Ok(_employmentStatusService.DeleteEmploymentStatuss(employmentStatusIds));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
