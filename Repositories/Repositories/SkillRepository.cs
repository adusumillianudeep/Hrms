using DataAccessLayer.Context;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class SkillRepository
    {
        private readonly HrmsEntities _dbContext;

        public SkillRepository()
        {
            _dbContext = new HrmsEntities();
        }

        public IQueryable<SkillModel> GetSkills()
        {
            return _dbContext.Skills
                .Where(x => x.RecordStatus == true)
                .Select(x => new SkillModel
                {
                    Description = x.Description,
                    Id = x.Id,
                    Name = x.Name
                });
        }

        public SkillModel SaveSkill(SkillModel skillModel)
        {
            var skill = new Skill
            {
                Description = skillModel.Description,
                Name = skillModel.Name
            };

            _dbContext.Skills.Add(skill);
            _dbContext.SaveChanges();

            skillModel.Id = skill.Id;
            return skillModel;
        }

        public SkillModel UpdateSkill(SkillModel skillModel)
        {
            var skill = _dbContext.Skills
                .FirstOrDefault(x => x.Id == skillModel.Id && x.RecordStatus == true);

            skill.Description = skillModel.Description;
            skill.Name = skillModel.Name;
            skill.UpdateDate = DateTime.Now;

            _dbContext.SaveChanges();

            return skillModel;
        }

        public SkillModel DeleteSkill(long skillId)
        {
            var skill = _dbContext.Skills
                .FirstOrDefault(x => x.Id == skillId);

            skill.RecordStatus = false;
            skill.UpdateDate = DateTime.Now;

            _dbContext.SaveChanges();

            return new SkillModel
            {
                Description = skill.Description,
                Id = skill.Id,
                Name = skill.Name
            };
        }

        public List<long> DeleteSkills(List<long> skillIds)
        {
            var skills = _dbContext.Skills
                .Where(x => skillIds.Contains(x.Id))
                .ToList();

            skills.ForEach(x => x.RecordStatus = false);
            skills.ForEach(x => x.UpdateDate = DateTime.Now);

            _dbContext.SaveChanges();

            return skillIds; 
        }
    }
}
