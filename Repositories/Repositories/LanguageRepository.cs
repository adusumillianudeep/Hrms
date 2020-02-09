using DataAccessLayer.Context;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class LanguageRepository
    {
        private readonly HrmsEntities _dbContext;

        public LanguageRepository()
        {
            _dbContext = new HrmsEntities();
        }

        public IQueryable<LanguageModel> GetLanguages()
        {
            return _dbContext.Languages
                .Where(x => x.RecordStatus == true)
                .Select(x => new LanguageModel
                {
                    Id = x.Id,
                    Name = x.Name
                });
        }

        public LanguageModel SaveLanguage(LanguageModel languageeModel)
        {
            var languagee = new Language
            {
                Name = languageeModel.Name
            };

            _dbContext.Languages.Add(languagee);
            _dbContext.SaveChanges();

            languageeModel.Id = languagee.Id;
            return languageeModel;
        }

        public LanguageModel UpdateLanguage(LanguageModel languageeModel)
        {
            var languagee = _dbContext.Languages
                .FirstOrDefault(x => x.Id == languageeModel.Id && x.RecordStatus == true);

            languagee.Name = languageeModel.Name;
            languagee.UpdateDate = DateTime.Now;

            _dbContext.SaveChanges();

            return languageeModel;
        }

        public LanguageModel DeleteLanguage(long languageeId)
        {
            var languagee = _dbContext.Languages
                .FirstOrDefault(x => x.Id == languageeId);

            languagee.RecordStatus = false;
            languagee.UpdateDate = DateTime.Now;

            _dbContext.SaveChanges();

            return new LanguageModel
            {
                Id = languagee.Id,
                Name = languagee.Name
            };
        }

        public List<long> DeleteLanguages(List<long> languageeId)
        {
            var languagee = _dbContext.Languages
                .Where(x => languageeId.Contains(x.Id))
                .ToList();

            languagee.ForEach(x => x.RecordStatus = false);
            languagee.ForEach(x => x.UpdateDate = DateTime.Now);

            _dbContext.SaveChanges();

            return languageeId;
        }
    }
}
