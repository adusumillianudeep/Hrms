using Model;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class LanguageService
    {
        private readonly LanguageRepository _languageRepository;
        private readonly SortingService _sortingService;
        private readonly PaginationService _paginationService;

        public LanguageService()
        {
            _languageRepository = new LanguageRepository();
            _sortingService = new SortingService();
            _paginationService = new PaginationService();
        }

        public List<LanguageModel> GetLanguages()
        {
            try
            {
                return _languageRepository.GetLanguages()
                                .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LanguageModel> GetLanguagesForPage(int pageNumber, int itemsPerPage, string sortField, string sortOrder)
        {
            try
            {
                var sortedLanguages = _sortingService.Sort(_languageRepository.GetLanguages(), sortField, sortOrder);

                return _paginationService.ApplyPaging(sortedLanguages, pageNumber, itemsPerPage)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public LanguageModel GetLanguage(long languageId)
        {
            try
            {
                return _languageRepository.GetLanguages()
                    .FirstOrDefault(x => x.Id == languageId);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LanguageModel SaveLanguage(LanguageModel language)
        {
            try
            {
                return _languageRepository.SaveLanguage(language);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LanguageModel UpdateLanguage(LanguageModel language)
        {
            try
            {
                return _languageRepository.UpdateLanguage(language);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LanguageModel DeleteLanguage(long languageId)
        {
            try
            {
                return _languageRepository.DeleteLanguage(languageId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<long> DeleteLanguages(List<long> languageIds)
        {
            try
            {
                return _languageRepository.DeleteLanguages(languageIds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
