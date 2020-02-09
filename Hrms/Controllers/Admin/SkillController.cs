using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace Hrms.Controllers.Admin
{
    [Route("api/skills")]
    public class SkillController : ApiController
    {
        private readonly SkillService _skillService;

        public SkillController()
        {
            _skillService = new SkillService();
        }

        [HttpGet]
        [Route("")]
        [ResponseType(typeof(IEnumerable<SkillModel>))]
        public IHttpActionResult GetSkills()
        {
            try
            {
                return Ok(_skillService.GetSkills());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("~/api/skillsforpage")]
        [ResponseType(typeof(IEnumerable<SkillModel>))]
        public IHttpActionResult GetSkillsForPage(int pageNumber = 1, int itemsPerPage = 10, string sortField = "Id", string sortOrder = "DESC")
        {
            try
            {
                if (!(sortOrder == SortingService.SortByAscending || sortOrder == SortingService.SortByDescending))
                {
                    return BadRequest("Invalid sort order");
                }

                return Ok(_skillService.GetSkillsForPage(pageNumber, itemsPerPage, sortField, sortOrder));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("{skillId}")]
        [ResponseType(typeof(SkillModel))]
        public IHttpActionResult GetSkill(long skillId)
        {
            try
            {
                return Ok(_skillService.GetSkill(skillId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        [ResponseType(typeof(SkillModel))]
        public IHttpActionResult SaveSkill(SkillModel skill)
        {
            try
            {
                return Ok(_skillService.SaveSkill(skill));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        [ResponseType(typeof(SkillModel))]
        public IHttpActionResult UpdateSkill(SkillModel skill)
        {
            try
            {
                if (skill.Id == null || skill.Id <= 0)
                {
                    return BadRequest("Invalid skill id");
                }

                return Ok(_skillService.UpdateSkill(skill));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        [Route("{skillId}")]
        [ResponseType(typeof(SkillModel))]
        public IHttpActionResult DeleteSkill(long skillId)
        {
            try
            {
                return Ok(_skillService.DeleteSkill(skillId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("deleteskills")]
        [ResponseType(typeof(SkillModel))]
        public IHttpActionResult DeleteSkills(List<long> skillIds)
        {
            try
            {
                return Ok(_skillService.DeleteSkills(skillIds));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
