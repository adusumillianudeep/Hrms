using Model;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class JobCategoryService
    {
        private readonly JobCategoryRepository _jobCategoryRepository;

        public JobCategoryService()
        {
            _jobCategoryRepository = new JobCategoryRepository();
        }

        public List<JobCategoryModel> GetJobCategoryList()
        {
            try
            {
                return _jobCategoryRepository.GetJobCategoryList()
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JobCategoryModel GetJobCategoryListById(long jobId)
        {
            try
            {
                return _jobCategoryRepository.GetJobCategoryList()
                    .FirstOrDefault(x => x.JobCategoryId == jobId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JobCategoryModel SaveJobCategory(JobCategoryModel jobCategory)
        {
            try
            {
                return _jobCategoryRepository.SaveJobCategory(jobCategory);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JobCategoryModel UpdateJobCategory(JobCategoryModel jobCategory)
        {
            try
            {
                return _jobCategoryRepository.UpdateJobCategory(jobCategory);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JobCategoryModel DeleteJobCategory(long jobCategoryId)
        {
            try
            {
                return _jobCategoryRepository.DeleteJobCategory(jobCategoryId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<long> DeleteJobCategorys(List<long> jobCategoryIds)
        {
            try
            {
                return _jobCategoryRepository.DeleteJobCategorys(jobCategoryIds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
