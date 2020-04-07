using DataAccessLayer.Context;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class JobRepository
    {
        private readonly HrmsEntities _dbContext;

        public JobRepository()
        {
            _dbContext = new HrmsEntities();
        }

        public IQueryable<JobModal> GetJobList()
        {
            //return _dbContext.Jobs
            //    .Select(x => new JobModal
            //    {
            //        JobId = x.JobId,
            //        Title = x.Title,
            //        Description = x.Description,
            //        Notes = x.Notes,
            //        JobSpecification = x.JobSpecification,
            //        OrganizationId = x.OrganizationId
            //    });

            throw new NotImplementedException();

        }

        public JobModal SaveJob(JobModal jobModal)
        {
            //var job = new Job
            //{
            //    Title = jobModal.Title,
            //    Description = jobModal.Description,
            //    Notes = jobModal.Notes,
            //    JobSpecification = jobModal.JobSpecification,
            //    OrganizationId = jobModal.OrganizationId
            //};

            //_dbContext.Jobs.Add(job);
            //_dbContext.SaveChanges();

            //jobModal.JobId = job.JobId;
            //return jobModal;

            throw new NotImplementedException();

        }

        public JobModal UpdateJob(JobModal jobModal)
        {
            //var job = _dbContext.Jobs
            //    .FirstOrDefault(x => x.JobId == jobModal.JobId);
            //if(job!=null)
            //{
            //    job.Title = jobModal.Title;
            //    job.Description = jobModal.Description;
            //    job.Notes = jobModal.Notes;
            //    job.JobSpecification = jobModal.JobSpecification;
            //    job.OrganizationId = jobModal.OrganizationId;
            //    _dbContext.SaveChanges();
            //}

            //return jobModal;

            throw new NotImplementedException();

        }

        public JobModal DeleteJob(long jobId)
        {
            //var job = _dbContext.Jobs
            //    .FirstOrDefault(x => x.JobId == jobId);

            //if(job!=null)
            //{
            //    _dbContext.Jobs.Remove(job);
            //    _dbContext.SaveChanges();
            //}
            //return new JobModal();

            throw new NotImplementedException();

        }

        public List<long> DeleteJobs(List<long> jobIds)
        {
            //var jobs = _dbContext.Jobs
            //    .Where(x => jobIds.Contains(x.JobId))
            //    .ToList();
            //if(jobs!=null && jobs.Count>0)
            //{
            //    foreach(Job job in jobs)
            //    {
            //        _dbContext.Jobs.Remove(job);
            //        _dbContext.SaveChanges();
            //    }
            //}
            //return jobIds;

            throw new NotImplementedException();
        }


    }
}
