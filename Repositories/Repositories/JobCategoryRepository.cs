using DataAccessLayer.Context;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class JobCategoryRepository
    {
        private readonly HrmsEntities _dbContext;

        public JobCategoryRepository()
        {
            _dbContext = new HrmsEntities();
        }

        public IQueryable<JobCategoryModel> GetJobCategoryList()
        {
            //return _dbContext.JobCategories
            //    .Select(x => new JobCategoryModel
            //    {
            //        JobCategoryId = x.JobCategoryId,
            //        Name = x.Name,
            //        OrganizationId = x.OrganizationId
            //    });

            throw new NotImplementedException();

        }

        public JobCategoryModel SaveJobCategory(JobCategoryModel JobCategoryModel)
        {
            //var JobCategory = new JobCategory
            //{
            //    Name = JobCategoryModel.Name,
            //    OrganizationId = JobCategoryModel.OrganizationId
            //};

            //_dbContext.JobCategories.Add(JobCategory);
            //_dbContext.SaveChanges();

            //JobCategoryModel.JobCategoryId = JobCategory.JobCategoryId;
            //return JobCategoryModel;
            throw new NotImplementedException();

        }

        public JobCategoryModel UpdateJobCategory(JobCategoryModel JobCategoryModel)
        {
            //var JobCategory = _dbContext.JobCategories
            //    .FirstOrDefault(x => x.JobCategoryId == JobCategoryModel.JobCategoryId);
            //if(JobCategory!=null)
            //{
            //    JobCategory.Name = JobCategoryModel.Name;
            //    JobCategory.OrganizationId = JobCategoryModel.OrganizationId;
            //    _dbContext.SaveChanges();
            //}

            //return JobCategoryModel;

            throw new NotImplementedException();

        }

        public JobCategoryModel DeleteJobCategory(long JobCategoryId)
        {
            //var JobCategory = _dbContext.JobCategories
            //    .FirstOrDefault(x => x.JobCategoryId == JobCategoryId);

            //if(JobCategory!=null)
            //{
            //    _dbContext.JobCategories.Remove(JobCategory);
            //    _dbContext.SaveChanges();
            //}
            //return new JobCategoryModel();

            throw new NotImplementedException();

        }

        public List<long> DeleteJobCategorys(List<long> JobCategoryIds)
        {
            //var JobCategorys = _dbContext.JobCategories
            //    .Where(x => JobCategoryIds.Contains(x.JobCategoryId))
            //    .ToList();
            //if(JobCategorys!=null && JobCategorys.Count>0)
            //{
            //    foreach(JobCategory JobCategory in JobCategorys)
            //    {
            //        _dbContext.JobCategories.Remove(JobCategory);
            //        _dbContext.SaveChanges();
            //    }
            //}
            //return JobCategoryIds;


            throw new NotImplementedException();
        }


    }
}
