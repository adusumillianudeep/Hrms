using Model;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class NationalityService
    {
        private readonly NationalityRepository _nationalityRepository;
        private readonly SortingService _sortingService;
        private readonly PaginationService _paginationService;

        public NationalityService()
        {
            _nationalityRepository = new NationalityRepository();
            _sortingService = new SortingService();
            _paginationService = new PaginationService();
        }

        public List<NationalityModel> GetNationalities()
        {
            try
            {
                return _nationalityRepository.GetNationalities()
                                .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<NationalityModel> GetNationalitiesForPage(int pageNumber, int itemsPerPage, string sortField, string sortOrder)
        {
            try
            {
                var sortedNationalities = _sortingService.Sort(_nationalityRepository.GetNationalities(), sortField, sortOrder);

                return _paginationService.ApplyPaging(sortedNationalities, pageNumber, itemsPerPage)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public NationalityModel GetNationality(long nationalityId)
        {
            try
            {
                return _nationalityRepository.GetNationalities()
                    .FirstOrDefault(x => x.Id == nationalityId);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public NationalityModel SaveNationality(NationalityModel nationality)
        {
            try
            {
                return _nationalityRepository.SaveNationality(nationality);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public NationalityModel UpdateNationality(NationalityModel nationality)
        {
            try
            {
                return _nationalityRepository.UpdateNationality(nationality);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public NationalityModel DeleteNationality(long nationalityId)
        {
            try
            {
                return _nationalityRepository.DeleteNationality(nationalityId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<long> DeleteNationalities(List<long> nationalityIds)
        {
            try
            {
                return _nationalityRepository.DeleteNationalities(nationalityIds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
