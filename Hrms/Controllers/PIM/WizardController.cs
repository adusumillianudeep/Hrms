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
    public class WizardController : ApiController
    {

        private readonly HrmsEntities _dbContext;

        public WizardController()
        {
            _dbContext = new HrmsEntities();
        }

        public IList<SectionDto> GetConfiguration()
        {
            return this._dbContext.Sections.Where(t => t.OrganizationId == 1).Select(s => new SectionDto
            {
                Id = s.Id,
                Name = s.Name,
                Available = s.Available,
                Fields = s.SectionFields.Select(sf => new SectionFieldDto
                {
                    Id = sf.Id,
                    Name = sf.Name,
                    Required = sf.Required,
                    Available = sf.Available
                }).ToList()
            }).ToList();
        }


        public bool SaveConfiguration(List<SectionDto> sections)
        {
            foreach (var s in sections)
            {
                var section = this._dbContext.Sections.Find(s.Id);

                if (section == null)
                {
                    // return bad data
                }

                section.Available = s.Available;

                foreach (var sf in s.Fields)
                {
                    var sectionField = this._dbContext.SectionFields.Find(sf.Id);

                    if (sectionField == null)
                    {
                        // return bad data
                    }

                    sectionField.Available = sf.Available;
                    sectionField.Required = sf.Required;
                }
            }

            this._dbContext.SaveChanges();

            return true;
        }
    }
}
