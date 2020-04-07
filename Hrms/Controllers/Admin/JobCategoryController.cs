using BusinessLayer;
using DataAccessLayer.Context;
using Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace Hrms.Controllers
{
    [RoutePrefix("api/jobcategory")]
    public class JobCategoryController : ApiController
    {
        private readonly JobCategoryService _jobCategoryService;

        private readonly HrmsEntities _dbContext;

        public JobCategoryController()
        {
            _dbContext = new HrmsEntities();

            _jobCategoryService = new JobCategoryService();
        }

        [HttpGet]
        [Route("list")]
        [ResponseType(typeof(IEnumerable<OptionModel>))]
        public IHttpActionResult Get()
        {
           return Ok(this._dbContext.JobCategories.Select(p=> new OptionModel { Text = p.Name, Value = p.Id.ToString()}).ToList());
        }

        [HttpGet]
        [Route("GetJobCategoryById")]
        [ResponseType(typeof(IEnumerable<JobCategoryModel>))]
        public IHttpActionResult GetJobCategoryById(long jobCategoryId)
        {
            try
            {
                return Ok(_jobCategoryService.GetJobCategoryById(jobCategoryId));
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
        [Route("DeleteJobCategorys")]
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
