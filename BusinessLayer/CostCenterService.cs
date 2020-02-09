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
        private readonly SortingService _sortingService;
        private readonly PaginationService _paginationService;

        public CostCenterService()
        {
            _costCenterRepository = new CostCenterRepository();
            _sortingService = new SortingService();
            _paginationService = new PaginationService();
        }

        public List<CostCenter> GetCostCenters()
        {
            try
            {
                return _costCenterRepository.GetCostCenters()
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CostCenter> GetCostCentersForPage(int pageNumber, int itemsPerPage, string sortField, string sortOrder)
        {
            var sortedCostCenters = _sortingService.Sort(_costCenterRepository.GetCostCenters(), sortField, sortOrder);

            return _paginationService.ApplyPaging(sortedCostCenters, pageNumber, itemsPerPage)
                .ToList();
        }

        public CostCenter GetCostCenterById(long costCenterId)
        {
            try
            {
                return _costCenterRepository.GetCostCenters()
                    .FirstOrDefault(x => x.Id == costCenterId);
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
                return _costCenterRepository.SaveCostCenter(costCenter);
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

                return _costCenterRepository.UpdateCostCenter(costCenter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CostCenter DeleteCostCenter(long id)
        {
            try
            {
                return _costCenterRepository.DeleteCostCenter(id);
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
                return _costCenterRepository.DeleteCostCenters(ids);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
