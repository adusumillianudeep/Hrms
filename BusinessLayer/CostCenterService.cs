using BusinessLayer.Mappers;
using DataAccessLayer;
using Model;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class CostCenterService
    {
        private readonly CostCenterRepository _costCenterRepository;

        public CostCenterService()
        {
            _costCenterRepository = new CostCenterRepository();
        }

        public List<CostCenter> GetCostCenters()
        {
            try
            {
                return _costCenterRepository.GetCostCenters();
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
                return _costCenterRepository.GetCostCenterById(id);
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
                var savedCostCenter = _costCenterRepository.SaveCostCenter(costCenter);

                return savedCostCenter;
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

                _costCenterRepository.UpdateCostCenter(costCenter);

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
                _costCenterRepository.DeleteCostCenter(id);
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
                _costCenterRepository.DeleteCostCenters(ids);
                return ids;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
