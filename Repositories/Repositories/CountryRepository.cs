using DataAccessLayer.Context;
using Model;
using System.Linq;

namespace Repositories.Repositories
{
    public class CountryRepository
    {
        private readonly HrmsEntities _dbContext;

        public CountryRepository()
        {
            _dbContext = new HrmsEntities();
        }

        public IQueryable<CountryModel> GetCountries()
        {
            return _dbContext.Countries
                .Select(x => new CountryModel
                {
                    Id = x.Id,
                    Name = x.Name
                });
        }
    }
}
