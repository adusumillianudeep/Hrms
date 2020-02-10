using DataAccessLayer.Context;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class NationalityRepository
    {
        private readonly HrmsEntities _dbContext;

        public NationalityRepository()
        {
            _dbContext = new HrmsEntities();
        }

        public IQueryable<NationalityModel> GetNationalities()
        {
            return _dbContext.Nationalities
                .Where(x => x.RecordStatus == true)
                .Select(x => new NationalityModel
                {
                    Id = x.Id,
                    Name = x.Name
                });
        }

        public NationalityModel SaveNationality(NationalityModel nationalityModel)
        {
            var nationality = new Nationality
            {
                Name = nationalityModel.Name
            };

            _dbContext.Nationalities.Add(nationality);
            _dbContext.SaveChanges();

            nationalityModel.Id = nationality.Id;
            return nationalityModel;
        }

        public NationalityModel UpdateNationality(NationalityModel nationalityModel)
        {
            var nationality = _dbContext.Nationalities
                .FirstOrDefault(x => x.Id == nationalityModel.Id && x.RecordStatus == true);

            nationality.Name = nationalityModel.Name;
            nationality.UpdateDate = DateTime.Now;

            _dbContext.SaveChanges();

            return nationalityModel;
        }

        public NationalityModel DeleteNationality(long nationalityId)
        {
            var nationality = _dbContext.Nationalities
                .FirstOrDefault(x => x.Id == nationalityId);

            nationality.RecordStatus = false;
            nationality.UpdateDate = DateTime.Now;

            _dbContext.SaveChanges();

            return new NationalityModel
            {
                Id = nationality.Id,
                Name = nationality.Name
            };
        }

        public List<long> DeleteNationalities(List<long> nationalityId)
        {
            var nationality = _dbContext.Nationalities
                .Where(x => nationalityId.Contains(x.Id))
                .ToList();

            nationality.ForEach(x => x.RecordStatus = false);
            nationality.ForEach(x => x.UpdateDate = DateTime.Now);

            _dbContext.SaveChanges();

            return nationalityId;
        }
    }
}
