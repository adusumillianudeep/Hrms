using Model;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class EducationService
    {
        private readonly EducationRepository _educationRepository;
        private readonly SortingService _sortingService;
        private readonly PaginationService _paginationService;

        public EducationService()
        {
            _educationRepository = new EducationRepository();
            _sortingService = new SortingService();
            _paginationService = new PaginationService();
        }

        public List<EducationModel> GetEducations()
        {
            try
            {
                return _educationRepository.GetEducations()
                                .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EducationModel> GetEducationsForPage(int pageNumber, int itemsPerPage, string sortField, string sortOrder)
        {
            try
            {
                var sortedEducations = _sortingService.Sort(_educationRepository.GetEducations(), sortField, sortOrder);

                return _paginationService.ApplyPaging(sortedEducations, pageNumber, itemsPerPage)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public EducationModel GetEducation(long educationId)
        {
            try
            {
                return _educationRepository.GetEducations()
                    .FirstOrDefault(x => x.Id == educationId);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EducationModel SaveEducation(EducationModel education)
        {
            try
            {
                return _educationRepository.SaveEducation(education);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EducationModel UpdateEducation(EducationModel education)
        {
            try
            {
                return _educationRepository.UpdateEducation(education);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EducationModel DeleteEducation(long educationId)
        {
            try
            {
                return _educationRepository.DeleteEducation(educationId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<long> DeleteEducations(List<long> educationIds)
        {
            try
            {
                return _educationRepository.DeleteEducations(educationIds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
