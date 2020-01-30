using BusinessLayer.Mappers;
using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class CostCenterService
    {
        private readonly CostCenterDataAccess _costCenterDataAccess;
        private readonly CostCenterMapper _costCenterMapper;
        public CostCenterService()
        {
            _costCenterDataAccess = new CostCenterDataAccess();
            _costCenterMapper = new CostCenterMapper();
        }

        public List<CostCenter> GetCostCenters()
        {
            try
            {
                return _costCenterMapper.Map(_costCenterDataAccess.GetCostCenters());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CostCenter GetCostCenterById(long id)
        {
            try
            {
                return _costCenterMapper.Map(_costCenterDataAccess.GetCostCenterById(id))
                .FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CostCenter SaveCostCenter(CostCenter costCenter)
        {
            try
            {
                var costCenterId = _costCenterDataAccess.SaveCostCenter(costCenter.Name, costCenter.Description);
                costCenter.Id = costCenterId;
                return costCenter;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CostCenter UpdateCostCenter(CostCenter costCenter)
        {
            try
            {
                if (costCenter.Id == null || costCenter.Id <= 0)
                {
                    throw new Exception("Cost center id not provided");
                }

                _costCenterDataAccess.UpdateCostCenter(costCenter.Id.GetValueOrDefault(), costCenter.Name, costCenter.Description);
                return costCenter;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteCostCenter(long id)
        {
            try
            {
                _costCenterDataAccess.DeleteCostCenter(id);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<long> DeleteCostCenters(List<long> ids)
        {
            try
            {
                _costCenterDataAccess.DeleteCostCenters(ids);
                return ids;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<long> DeleteCostCentersMultiple(List<long> ids)
        {
            try
            {
                foreach(var id in ids)
                {
                    _costCenterDataAccess.DeleteCostCenter(id);
                }
                return ids;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
