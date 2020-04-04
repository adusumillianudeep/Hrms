using DataAccessLayer.Context;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Hrms.Controllers.PIM
{
    public class CustomFieldsController : ApiController
    {
        private readonly HrmsEntities _dbContext;

        public CustomFieldsController()
        {
            _dbContext = new HrmsEntities();
        }

        [HttpPost]
        public int SaveTitle(CustomSectionDto customSectionDto)
        {
            Section customSection;
            if (customSectionDto.Id > 0)
            {
                customSection = this._dbContext.Sections.Find(customSectionDto.Id);
                if (customSection == null)
                {
                    // bad data
                }
                else
                {
                    customSection.Name = customSectionDto.Name;
                    customSection.ParentId = customSectionDto.ParentId;
                }
            }
            else
            {
                customSection = new Section();
                customSection.Name = customSectionDto.Name;
                customSection.ParentId = customSectionDto.ParentId;
                customSection.OrganizationId = 1;
                customSection.Available = false;
                this._dbContext.Sections.Add(customSection);
            }

            this._dbContext.SaveChanges();

            return customSection.Id;
        }

    }
}
