using Model;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class JobService
    {
        private readonly JobRepository _jobRepository;

        public JobService()
        {
            _jobRepository = new JobRepository();
        }

        public List<JobModal> GetJobList()
        {
            try
            {
                return _jobRepository.GetJobList()
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JobModal GetJobListById(long jobId)
        {
            try
            {
                return _jobRepository.GetJobList()
                    .FirstOrDefault(x => x.JobId == jobId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JobModal SaveJob(JobModal job)
        {
            try
            {
                return _jobRepository.SaveJob(job);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JobModal UpdateJob(JobModal job)
        {
            try
            {
                return _jobRepository.UpdateJob(job);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JobModal DeleteJob(long jobId)
        {
            try
            {
                return _jobRepository.DeleteJob(jobId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<long> DeleteJobs(List<long> jobIds)
        {
            try
            {
                return _jobRepository.DeleteJobs(jobIds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
