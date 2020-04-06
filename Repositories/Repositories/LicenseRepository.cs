using DataAccessLayer.Context;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class LicenseRepository
    {
        private readonly HrmsEntities _dbContext;

        public LicenseRepository()
        {
            _dbContext = new HrmsEntities();
        }

        public IQueryable<LicenseModel> GetLicenses()
        {
            //return _dbContext.Licenses
            //    .Where(x => x.RecordStatus == true)
            //    .Select(x => new LicenseModel
            //    {
            //        Id = x.Id,
            //        Name = x.Name
            //    });
            return null;

        }

        public LicenseModel SaveLicense(LicenseModel licenseModel)
        {
            //var license = new License
            //{
            //    Name = licenseModel.Name
            //};

            //_dbContext.Licenses.Add(license);
            //_dbContext.SaveChanges();

            //licenseModel.Id = license.Id;
            //return licenseModel;

            return null;

        }

        public LicenseModel UpdateLicense(LicenseModel licenseModel)
        {
            //var license = _dbContext.Licenses
            //    .FirstOrDefault(x => x.Id == licenseModel.Id && x.RecordStatus == true);

            //license.Name = licenseModel.Name;
            //license.UpdateDate = DateTime.Now;

            //_dbContext.SaveChanges();

            //return licenseModel;
            throw new NotImplementedException();
        }

        public LicenseModel DeleteLicense(long licenseId)
        {
            //var license = _dbContext.Licenses
            //    .FirstOrDefault(x => x.Id == licenseId);

            //license.RecordStatus = false;
            //license.UpdateDate = DateTime.Now;

            //_dbContext.SaveChanges();

            //return new LicenseModel
            //{
            //    Id = license.Id,
            //    Name = license.Name
            //};
            throw new NotImplementedException();

        }

        public List<long> DeleteLicenses(List<long> licenseId)
        {
            //var license = _dbContext.Licenses
            //    .Where(x => licenseId.Contains(x.Id))
            //    .ToList();

            //license.ForEach(x => x.RecordStatus = false);
            //license.ForEach(x => x.UpdateDate = DateTime.Now);

            //_dbContext.SaveChanges();

            //return licenseId;

            throw new NotImplementedException();

        }
    }
}
