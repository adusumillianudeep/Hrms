using DataAccessLayer.Context;
using Model;
using System.Linq;

namespace Repositories.Repositories
{
    public class TimeZoneRepository
    {
        private readonly HrmsEntities _dbContext;

        public TimeZoneRepository()
        {
            _dbContext = new HrmsEntities();
        }

        public IQueryable<TimeZoneModel> GetTimeZones()
        {
            return _dbContext.TimeZones
                .Select(x => new TimeZoneModel
                {
                    Id = x.Id,
                    TimeZone = x.TimeZone1
                });
        }
    }
}
