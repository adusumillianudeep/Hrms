using DataAccessLayer.Context;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class EducationRepository
    {
        private readonly HrmsEntities _dbContext;

        public EducationRepository()
        {
            _dbContext = new HrmsEntities();
        }

        public IQueryable<EducationModel> GetEducations()
        {
            return _dbContext.Educations
                .Where(x => x.RecordStatus == true)
                .Select(x => new EducationModel
                {
                    Id = x.Id,
                    Name = x.Name
                });
        }

        public EducationModel SaveEducation(EducationModel educationModel)
        {
            var education = new Education
            {
                Name = educationModel.Name
            };

            _dbContext.Educations.Add(education);
            _dbContext.SaveChanges();

            educationModel.Id = education.Id;
            return educationModel;
        }

        public EducationModel UpdateEducation(EducationModel educationModel)
        {
            var education = _dbContext.Educations
                .FirstOrDefault(x => x.Id == educationModel.Id && x.RecordStatus == true);

            education.Name = educationModel.Name;
            education.UpdateDate = DateTime.Now;

            _dbContext.SaveChanges();

            return educationModel;
        }

        public EducationModel DeleteEducation(long educationId)
        {
            var education = _dbContext.Educations
                .FirstOrDefault(x => x.Id == educationId);

            education.RecordStatus = false;
            education.UpdateDate = DateTime.Now;

            _dbContext.SaveChanges();

            return new EducationModel
            {
                Id = education.Id,
                Name = education.Name
            };
        }

        public List<long> DeleteEducations(List<long> educationId)
        {
            var education = _dbContext.Educations
                .Where(x => educationId.Contains(x.Id))
                .ToList();

            education.ForEach(x => x.RecordStatus = false);
            education.ForEach(x => x.UpdateDate = DateTime.Now);

            _dbContext.SaveChanges();

            return educationId;
        }
    }
}
