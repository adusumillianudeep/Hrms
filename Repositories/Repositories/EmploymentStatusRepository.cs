using DataAccessLayer.Context;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class EmploymentStatusRepository
    {
        private readonly HrmsEntities _dbContext;

        public EmploymentStatusRepository()
        {
            _dbContext = new HrmsEntities();
        }

        public IQueryable<EmploymentStatusModel> GetEmploymentStatusList()
        {
            return _dbContext.EmploymentStatus
                .Select(x => new EmploymentStatusModel
                {
                    EmploymentStatusId = x.EmploymentStatusId,
                    Name = x.Name,
                    OrganizationId = x.OrganizationId
                });
        }

        public EmploymentStatusModel SaveEmploymentStatus(EmploymentStatusModel EmploymentStatusModel)
        {
            var EmploymentStatus = new EmploymentStatu
            {
                Name = EmploymentStatusModel.Name,
                OrganizationId = EmploymentStatusModel.OrganizationId
            };

            _dbContext.EmploymentStatus.Add(EmploymentStatus);
            _dbContext.SaveChanges();

            EmploymentStatusModel.EmploymentStatusId = EmploymentStatus.EmploymentStatusId;
            return EmploymentStatusModel;
        }

        public EmploymentStatusModel UpdateEmploymentStatus(EmploymentStatusModel EmploymentStatusModel)
        {
            var EmploymentStatus = _dbContext.EmploymentStatus
                .FirstOrDefault(x => x.EmploymentStatusId == EmploymentStatusModel.EmploymentStatusId);
            if(EmploymentStatus!=null)
            {
                EmploymentStatus.Name = EmploymentStatusModel.Name;
                EmploymentStatus.OrganizationId = EmploymentStatusModel.OrganizationId;
                _dbContext.SaveChanges();
            }

            return EmploymentStatusModel;
        }

        public EmploymentStatusModel DeleteEmploymentStatus(long EmploymentStatusId)
        {
            var EmploymentStatus = _dbContext.EmploymentStatus
                .FirstOrDefault(x => x.EmploymentStatusId == EmploymentStatusId);

            if(EmploymentStatus!=null)
            {
                _dbContext.EmploymentStatus.Remove(EmploymentStatus);
                _dbContext.SaveChanges();
            }
            return new EmploymentStatusModel();
        }

        public List<long> DeleteEmploymentStatuss(List<long> EmploymentStatusIds)
        {
            var EmploymentStatuss = _dbContext.EmploymentStatus
                .Where(x => EmploymentStatusIds.Contains(x.EmploymentStatusId))
                .ToList();
            if(EmploymentStatuss!=null && EmploymentStatuss.Count>0)
            {
                foreach(EmploymentStatu EmploymentStatus in EmploymentStatuss)
                {
                    _dbContext.EmploymentStatus.Remove(EmploymentStatus);
                    _dbContext.SaveChanges();
                }
            }
            return EmploymentStatusIds;
        }


    }
}
