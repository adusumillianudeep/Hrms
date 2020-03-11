using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace Hrms.Controllers
{
    [RoutePrefix("api/workshift")]
    public class WorkShiftController : ApiController
    {
        private readonly WorkShiftService _workShiftService;

        public WorkShiftController()
        {
            _workShiftService = new WorkShiftService();
        }

        [HttpGet]
        [Route("GetWorkShiftList")]
        [ResponseType(typeof(IEnumerable<WorkShiftModel>))]
        public IHttpActionResult GetWorkShiftList()
        {
            try
            {
                return Ok(_workShiftService.GetWorkShiftList());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("GetWorkShiftById")]
        [ResponseType(typeof(IEnumerable<WorkShiftModel>))]
        public IHttpActionResult GetWorkShiftById(long workShiftId)
        {
            try
            {
                return Ok(_workShiftService.GetWorkShiftById(workShiftId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("SaveWorkShift")]
        [ResponseType(typeof(WorkShiftModel))]
        public IHttpActionResult SaveWorkShift(WorkShiftModel workShift)
        {
            try
            {
                return Ok(_workShiftService.SaveWorkShift(workShift));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        [HttpPut]
        [Route("UpdateWorkShift")]
        [ResponseType(typeof(WorkShiftModel))]
        public IHttpActionResult UpdateWorkShift(WorkShiftModel workShiftModel)
        {
            try
            {
                if (workShiftModel.WorkShiftId <= 0)
                {
                    return BadRequest("Invalid WorkShift id");
                }

                return Ok(_workShiftService.UpdateWorkShift(workShiftModel));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        [Route("delete/{workShiftId}")]
        [ResponseType(typeof(WorkShiftModel))]
        public IHttpActionResult DeleteWorkShift(long workShiftId)
        {
            try
            {
                return Ok(_workShiftService.DeleteWorkShift(workShiftId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("DeleteWorkShifts")]
        [ResponseType(typeof(WorkShiftModel))]
        public IHttpActionResult DeleteWorkShifts(List<long> workShiftIds)
        {
            try
            {
                return Ok(_workShiftService.DeleteWorkShifts(workShiftIds));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
