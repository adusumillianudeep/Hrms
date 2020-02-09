using Model;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class LicenseService
    {
        private readonly LicenseRepository _licenseRepository;
        private readonly SortingService _sortingService;
        private readonly PaginationService _paginationService;

        public LicenseService()
        {
            _licenseRepository = new LicenseRepository();
            _sortingService = new SortingService();
            _paginationService = new PaginationService();
        }

        public List<LicenseModel> GetLicenses()
        {
            try
            {
                return _licenseRepository.GetLicenses()
                                .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LicenseModel> GetLicensesForPage(int pageNumber, int itemsPerPage, string sortField, string sortOrder)
        {
            try
            {
                var sortedLicenses = _sortingService.Sort(_licenseRepository.GetLicenses(), sortField, sortOrder);

                return _paginationService.ApplyPaging(sortedLicenses, pageNumber, itemsPerPage)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public LicenseModel GetLicense(long licenseId)
        {
            try
            {
                return _licenseRepository.GetLicenses()
                    .FirstOrDefault(x => x.Id == licenseId);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LicenseModel SaveLicense(LicenseModel license)
        {
            try
            {
                return _licenseRepository.SaveLicense(license);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LicenseModel UpdateLicense(LicenseModel license)
        {
            try
            {
                return _licenseRepository.UpdateLicense(license);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LicenseModel DeleteLicense(long licenseId)
        {
            try
            {
                return _licenseRepository.DeleteLicense(licenseId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<long> DeleteLicenses(List<long> licenseIds)
        {
            try
            {
                return _licenseRepository.DeleteLicenses(licenseIds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
