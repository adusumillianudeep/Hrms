using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace Hrms.Controllers
{
    [RoutePrefix("api/jobcategory")]
    public class JobCategoryController : ApiController
    {
        private readonly JobCategoryService _jobCategoryService;

        public JobCategoryController()
        {
            _jobCategoryService = new JobCategoryService();
        }

        [HttpGet]
        [Route("GetJobCategoryList")]
        [ResponseType(typeof(IEnumerable<JobCategoryModel>))]
        public IHttpActionResult GetJobCategoryList()
        {
            try
            {
                return Ok(_jobCategoryService.GetJobCategoryList());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("GetJobCategoryById")]
        [ResponseType(typeof(IEnumerable<JobCategoryModel>))]
        public IHttpActionResult GetJobCategoryListById(long jobCategoryId)
        {
            try
            {
                return Ok(_jobCategoryService.GetJobCategoryListById(jobCategoryId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("SaveJobCategory")]
        [ResponseType(typeof(JobCategoryModel))]
        public IHttpActionResult SaveJobCategory(JobCategoryModel jobCategory)
        {
            try
            {
                return Ok(_jobCategoryService.SaveJobCategory(jobCategory));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        [HttpPut]
        [Route("UpdateJobCategory")]
        [ResponseType(typeof(JobCategoryModel))]
        public IHttpActionResult UpdateJobCategory(JobCategoryModel jobCategoryModel)
        {
            try
            {
                if (jobCategoryModel.JobCategoryId <= 0)
                {
                    return BadRequest("Invalid JobCategory id");
                }

                return Ok(_jobCategoryService.UpdateJobCategory(jobCategoryModel));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        [Route("delete/{jobCategoryId}")]
        [ResponseType(typeof(JobCategoryModel))]
        public IHttpActionResult DeleteJobCategory(long jobCategoryId)
        {
            try
            {
                return Ok(_jobCategoryService.DeleteJobCategory(jobCategoryId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("DeleteJobCategoryList")]
        [ResponseType(typeof(JobCategoryModel))]
        public IHttpActionResult DeleteJobCategorys(List<long> jobCategoryIds)
        {
            try
            {
                return Ok(_jobCategoryService.DeleteJobCategorys(jobCategoryIds));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
