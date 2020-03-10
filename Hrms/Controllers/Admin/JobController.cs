using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace Hrms.Controllers
{
    [RoutePrefix("api/jobs")]
    public class JobController : ApiController
    {
        private readonly JobService _jobService;

        public JobController()
        {
            _jobService = new JobService();
        }

        [HttpGet]
        [Route("GetJobList")]
        [ResponseType(typeof(IEnumerable<JobModal>))]
        public IHttpActionResult GetJobList()
        {
            try
            {
                return Ok(_jobService.GetJobList());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("GetJobListById")]
        [ResponseType(typeof(IEnumerable<JobModal>))]
        public IHttpActionResult GetJobListById(long jobId)
        {
            try
            {
                return Ok(_jobService.GetJobListById(jobId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("SaveJob")]
        [ResponseType(typeof(JobModal))]
        public IHttpActionResult SaveJob(JobModal job)
        {
            try
            {
                return Ok(_jobService.SaveJob(job));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        [HttpPut]
        [Route("UpdateJob")]
        [ResponseType(typeof(JobModal))]
        public IHttpActionResult UpdateJob(JobModal jobModal)
        {
            try
            {
                if (jobModal.JobId <= 0)
                {
                    return BadRequest("Invalid nationality id");
                }

                return Ok(_jobService.UpdateJob(jobModal));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        [Route("delete/{jobId}")]
        [ResponseType(typeof(JobModal))]
        public IHttpActionResult DeleteJob(long jobId)
        {
            try
            {
                return Ok(_jobService.DeleteJob(jobId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("DeleteJobs")]
        [ResponseType(typeof(JobModal))]
        public IHttpActionResult DeleteJobs(List<long> jobIds)
        {
            try
            {
                return Ok(_jobService.DeleteJobs(jobIds));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
