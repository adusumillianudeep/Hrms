using Model;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class LocationService
    {
        private readonly LocationRepository _locationRepository;
        private readonly CountryRepository _countryRepository;
        private readonly TimeZoneRepository _timeZoneRepository;
        private readonly SortingService _sortingService;
        private readonly PaginationService _paginationService;

        public LocationService()
        {
            _locationRepository = new LocationRepository();
            _countryRepository = new CountryRepository();
            _timeZoneRepository = new TimeZoneRepository();
            _sortingService = new SortingService();
            _paginationService = new PaginationService();
        }

        public List<LocationModel> GetLocations()
        {
            try
            {
                return _locationRepository.GetLocations()
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LocationModel> GetLocationsForPage(int pageNumber, int itemsPerPage, string sortField, string sortOrder)
        {
            var sortedLocations = _sortingService.Sort(_locationRepository.GetLocations(), sortField, sortOrder);

            return _paginationService.ApplyPaging(sortedLocations, pageNumber, itemsPerPage)
                .ToList();
        }

        public LocationModel GetLocation(long locationId)
        {
            try
            {
                return _locationRepository.GetLocations()
                    .FirstOrDefault(x => x.Id == locationId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LocationModel SaveLocation(LocationModel location)
        {
            try
            {
                return _locationRepository.SaveLocation(location);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LocationModel UpdateLocation(LocationModel location)
        {
            try
            {
                if (location.Id == null || location.Id <= 0)
                {
                    throw new Exception("Location id not provided");
                }

                return _locationRepository.UpdateLocation(location);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LocationModel DeleteLocation(long locationId)
        {
            try
            {
                return _locationRepository.DeleteLocation(locationId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<long> DeleteLocations(List<long> locationIds)
        {
            try
            {
                return _locationRepository.DeleteLocations(locationIds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CountryTimeZoneModel GetCountryTimeZone()
        {
            return new CountryTimeZoneModel
            {
                Countries = _countryRepository.GetCountries().ToList(),
                TimeZones = _timeZoneRepository.GetTimeZones().ToList()
            };
        }
    }
}
