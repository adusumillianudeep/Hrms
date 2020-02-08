using Model;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class TimeZoneService
    {
        private readonly TimeZoneRepository _timeZoneRepository;

        public TimeZoneService()
        {
            _timeZoneRepository = new TimeZoneRepository();
        }

        public List<TimeZoneModel> GetTimeZones()
        {
            try
            {
                return _timeZoneRepository.GetTimeZones()
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TimeZoneModel GetTimeZone(long timeZoneId)
        {
            try
            {
                return _timeZoneRepository.GetTimeZones()
                    .FirstOrDefault(x => x.Id == timeZoneId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
