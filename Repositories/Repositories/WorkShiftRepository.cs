using DataAccessLayer.Context;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class WorkShiftRepository
    {
        private readonly HrmsEntities _dbContext;

        public WorkShiftRepository()
        {
            _dbContext = new HrmsEntities();
        }

        public IQueryable<WorkShiftModel> GetWorkShiftList()
        {
            return _dbContext.WorkShifts
                .Select(x => new WorkShiftModel
                {
                    WorkShiftId = x.WorkShiftId,
                    From = x.From,
                    To = x.To,
                    Name = x.Name,
                    OrganizationId = x.OrganizationId
                });
        }

        public WorkShiftModel SaveWorkShift(WorkShiftModel WorkShiftModel)
        {
            var WorkShift = new WorkShift
            {
                Name = WorkShiftModel.Name,
                From = WorkShiftModel.From,
                To = WorkShiftModel.To,
                OrganizationId = WorkShiftModel.OrganizationId
            };

            _dbContext.WorkShifts.Add(WorkShift);
            _dbContext.SaveChanges();

            WorkShiftModel.WorkShiftId = WorkShift.WorkShiftId;
            return WorkShiftModel;
        }

        public WorkShiftModel UpdateWorkShift(WorkShiftModel WorkShiftModel)
        {
            var WorkShift = _dbContext.WorkShifts
                .FirstOrDefault(x => x.WorkShiftId == WorkShiftModel.WorkShiftId);
            if(WorkShift!=null)
            {
                WorkShift.Name = WorkShiftModel.Name;
                WorkShift.From = WorkShiftModel.From;
                WorkShift.To = WorkShiftModel.To;
                WorkShift.OrganizationId = WorkShiftModel.OrganizationId;
                _dbContext.SaveChanges();
            }

            return WorkShiftModel;
        }

        public WorkShiftModel DeleteWorkShift(long workShiftId)
        {
            var WorkShift = _dbContext.WorkShifts
                .FirstOrDefault(x => x.WorkShiftId == workShiftId);

            if(WorkShift!=null)
            {
                _dbContext.WorkShifts.Remove(WorkShift);
                _dbContext.SaveChanges();
            }
            return new WorkShiftModel();
        }

        public List<long> DeleteWorkShifts(List<long> workShiftIds)
        {
            var WorkShifts = _dbContext.WorkShifts
                .Where(x => workShiftIds.Contains(x.WorkShiftId))
                .ToList();
            if(WorkShifts!=null && WorkShifts.Count>0)
            {
                foreach(WorkShift WorkShift in WorkShifts)
                {
                    _dbContext.WorkShifts.Remove(WorkShift);
                    _dbContext.SaveChanges();
                }
            }
            return workShiftIds;
        }


    }
}
