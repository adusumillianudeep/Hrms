using DataAccessLayer.Context;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class LocationRepository
    {
        private readonly HrmsEntities _dbContext;

        public LocationRepository()
        {
            _dbContext = new HrmsEntities();
        }

        public IQueryable<LocationModel> GetLocations()
        {
            return _dbContext.Locations
                .Where(x => x.RecordStatus == true)
                .Select(x => new LocationModel
                {
                    Address = x.Address,
                    City = x.City,
                    CountryId = x.CountryId,
                    EeoEnabled = x.EeoEnabled,
                    Fax = x.Fax,
                    Id = x.Id,
                    Name = x.Name,
                    Notes = x.Notes,
                    Phone = x.Phone,
                    State = x.State,
                    TimeZoneId = x.TimeZoneId,
                    ZipCode = x.ZipCode
                });
        }

        public LocationModel SaveLocation(LocationModel locationModel)
        {
            var location = new Location
            {
                Address = locationModel.Address,
                City = locationModel.City,
                CountryId = locationModel.CountryId,
                EeoEnabled = locationModel.EeoEnabled,
                Fax = locationModel.Fax,
                Name = locationModel.Name,
                Notes = locationModel.Notes,
                Phone = locationModel.Phone,
                State = locationModel.State,
                TimeZoneId = locationModel.TimeZoneId,
                ZipCode = locationModel.ZipCode
            };

            _dbContext.Locations.Add(location);
            _dbContext.SaveChanges();

            locationModel.Id = location.Id;
            return locationModel;
        }

        public LocationModel UpdateLocation(LocationModel locationModel)
        {
            var location = _dbContext.Locations
                .FirstOrDefault(x => x.Id == locationModel.Id.GetValueOrDefault() && x.RecordStatus == true);

            location.Address = locationModel.Address;
            location.City = locationModel.City;
            location.CountryId = locationModel.CountryId;
            location.EeoEnabled = locationModel.EeoEnabled;
            location.Fax = locationModel.Fax;
            location.Id = locationModel.Id.GetValueOrDefault();
            location.Name = locationModel.Name;
            location.Notes = locationModel.Notes;
            location.Phone = locationModel.Phone;
            location.State = locationModel.State;
            location.TimeZoneId = locationModel.TimeZoneId;
            location.UpdateDate = DateTime.Now;
            location.ZipCode = locationModel.ZipCode;

            _dbContext.SaveChanges();

            return locationModel;
        }

        public LocationModel DeleteLocation(long locationId)
        {
            var location = _dbContext.Locations
                .FirstOrDefault(x => x.Id == locationId);
            location.RecordStatus = false;
            location.UpdateDate = DateTime.Now;

            _dbContext.SaveChanges();

            return new LocationModel
            {
                Address = location.Address,
                City = location.City,
                CountryId = location.CountryId,
                EeoEnabled = location.EeoEnabled,
                Fax = location.Fax,
                Id = location.Id,
                Name = location.Name,
                Notes = location.Notes,
                Phone = location.Phone,
                State = location.State,
                TimeZoneId = location.TimeZoneId,
                ZipCode = location.ZipCode
            };
        }

        public List<long> DeleteLocations(List<long> locationIds)
        {
            var locations = _dbContext.Locations
                .Where(x => locationIds.Contains(x.Id))
                .ToList();
            locations.ForEach(x => x.RecordStatus = false);
            locations.ForEach(x => x.UpdateDate = DateTime.Now);

            _dbContext.SaveChanges();

            return locationIds;
        }
    }
}
