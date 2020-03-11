using Model;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class EmploymentStatusService
    {
        private readonly EmploymentStatusRepository _employmentStatusRepository;

        public EmploymentStatusService()
        {
            _employmentStatusRepository = new EmploymentStatusRepository();
        }

        public List<EmploymentStatusModel> GetEmploymentStatusList()
        {
            try
            {
                return _employmentStatusRepository.GetEmploymentStatusList()
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EmploymentStatusModel GetEmploymentStatusById(long employmentStatusId)
        {
            try
            {
                return _employmentStatusRepository.GetEmploymentStatusList()
                    .FirstOrDefault(x => x.EmploymentStatusId == employmentStatusId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EmploymentStatusModel SaveEmploymentStatus(EmploymentStatusModel employmentStatus)
        {
            try
            {
                return _employmentStatusRepository.SaveEmploymentStatus(employmentStatus);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EmploymentStatusModel UpdateEmploymentStatus(EmploymentStatusModel employmentStatus)
        {
            try
            {
                return _employmentStatusRepository.UpdateEmploymentStatus(employmentStatus);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EmploymentStatusModel DeleteEmploymentStatus(long employmentStatusId)
        {
            try
            {
                return _employmentStatusRepository.DeleteEmploymentStatus(employmentStatusId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<long> DeleteEmploymentStatuss(List<long> employmentStatusIds)
        {
            try
            {
                return _employmentStatusRepository.DeleteEmploymentStatuss(employmentStatusIds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
