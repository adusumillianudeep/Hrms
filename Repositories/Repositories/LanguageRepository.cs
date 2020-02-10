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

        public LanguageModel SaveLanguage(LanguageModel languageModel)
        {
            var language = new Language
            {
                Name = languageModel.Name
            };

            _dbContext.Languages.Add(language);
            _dbContext.SaveChanges();

            languageModel.Id = language.Id;
            return languageModel;
        }

        public LanguageModel UpdateLanguage(LanguageModel languageModel)
        {
            var language = _dbContext.Languages
                .FirstOrDefault(x => x.Id == languageModel.Id && x.RecordStatus == true);

            language.Name = languageModel.Name;
            language.UpdateDate = DateTime.Now;

            _dbContext.SaveChanges();

            return languageModel;
        }

        public LanguageModel DeleteLanguage(long languageId)
        {
            var language = _dbContext.Languages
                .FirstOrDefault(x => x.Id == languageId);

            language.RecordStatus = false;
            language.UpdateDate = DateTime.Now;

            _dbContext.SaveChanges();

            return new LanguageModel
            {
                Id = language.Id,
                Name = language.Name
            };
        }

        public List<long> DeleteLanguages(List<long> languageId)
        {
            var language = _dbContext.Languages
                .Where(x => languageId.Contains(x.Id))
                .ToList();

            language.ForEach(x => x.RecordStatus = false);
            language.ForEach(x => x.UpdateDate = DateTime.Now);

            _dbContext.SaveChanges();

            return languageId;
        }
    }
}
