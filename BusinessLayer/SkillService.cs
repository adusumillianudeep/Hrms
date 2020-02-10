using Model;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class SkillService
    {
        private readonly SkillRepository _skillRepository;
        private readonly SortingService _sortingService;
        private readonly PaginationService _paginationService;

        public SkillService()
        {
            _skillRepository = new SkillRepository();
            _sortingService = new SortingService();
            _paginationService = new PaginationService();
        }

        public List<SkillModel> GetSkills()
        {
            try
            {
                return _skillRepository.GetSkills()
                                .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SkillModel> GetSkillsForPage(int pageNumber, int itemsPerPage, string sortField, string sortOrder)
        {
            try
            {
                var sortedSkills = _sortingService.Sort(_skillRepository.GetSkills(), sortField, sortOrder);

                return _paginationService.ApplyPaging(sortedSkills, pageNumber, itemsPerPage)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public SkillModel GetSkill(long skillId)
        {
            try
            {
                return _skillRepository.GetSkills()
                    .FirstOrDefault(x => x.Id == skillId);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SkillModel SaveSkill(SkillModel skill)
        {
            try
            {
                return _skillRepository.SaveSkill(skill);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SkillModel UpdateSkill(SkillModel skill)
        {
            try
            {
                return _skillRepository.UpdateSkill(skill);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SkillModel DeleteSkill(long skillId)
        {
            try
            {
                return _skillRepository.DeleteSkill(skillId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<long> DeleteSkills(List<long> skillIds)
        {
            try
            {
                return _skillRepository.DeleteSkills(skillIds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
