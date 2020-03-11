using Model;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class WorkShiftService
    {
        private readonly WorkShiftRepository _workShiftRepository;

        public WorkShiftService()
        {
            _workShiftRepository = new WorkShiftRepository();
        }

        public List<WorkShiftModel> GetWorkShiftList()
        {
            try
            {
                return _workShiftRepository.GetWorkShiftList()
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public WorkShiftModel GetWorkShiftById(long workShiftId)
        {
            try
            {
                return _workShiftRepository.GetWorkShiftList()
                    .FirstOrDefault(x => x.WorkShiftId == workShiftId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public WorkShiftModel SaveWorkShift(WorkShiftModel WorkShiftModel)
        {
            try
            {
                return _workShiftRepository.SaveWorkShift(WorkShiftModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public WorkShiftModel UpdateWorkShift(WorkShiftModel WorkShiftModel)
        {
            try
            {
                return _workShiftRepository.UpdateWorkShift(WorkShiftModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public WorkShiftModel DeleteWorkShift(long workShiftId)
        {
            try
            {
                return _workShiftRepository.DeleteWorkShift(workShiftId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<long> DeleteWorkShifts(List<long> workShiftIds)
        {
            try
            {
                return _workShiftRepository.DeleteWorkShifts(workShiftIds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
