using BusinessLayer;
using DataAccessLayer.Context;
using Model;
using System;
using System.Web.Http;
using System.Linq;
using System.Collections.Generic;

namespace Hrms.Controllers.PIM
{
    [RoutePrefix("api/employee")]
    public class EmployeeController : ApiController
    {
        private readonly EmployeeService _service;


        private readonly HrmsEntities _dbContext;


        public EmployeeController()
        {
            _dbContext = new HrmsEntities();

            _service = new EmployeeService();
        }

        [HttpGet]
        [Route("get-list")]
        public IList<EmployeeListModel> GetEmployeeList()
        {
            var r = (
                from e in this._dbContext.Employees
                join pd in this._dbContext.PersonalDetails on e.Id equals pd.EmployeeId
                select new EmployeeListModel
                {
                    Id = e.Id,
                    FirstName = pd.FirstName,
                    LastName = pd.LastName,
                    FullName = pd.FirstName + " " + pd.LastName,
                    JobTitle = "Developer",
                    Status = "Active",
                    CostCenter = "Cost Center",
                    Location = "Pune",
                    SubUnit = "Pune",
                    Supervisor = "Admin"
                }).ToList();

            return r;
        }

        [HttpPost]
        [Route("save")]
        public IHttpActionResult SaveEmployee(EmployeeDataModel ed)
        {
            var newEmp = new Employee
            {
                OrganizationId = 1
            };

            if (ed.AddLoginDetail)
            {
                // add code to create user here
            }

            var epd = new PersonalDetail
            {
                FirstName = ed.personalDetail.FirstName,
                LastName = ed.personalDetail.LastName,
                MiddleName = ed.personalDetail.MiddleName,
                Gender = ed.personalDetail.Gender,
                CountryId = ed.personalDetail.CountryId,
                DOB = null, // ed.personalDetail.DOB;
                MaritalStatus = ed.personalDetail.MaritalStatus,
                LicenseNumber = ed.personalDetail.LicenseNumber,
                LicenseExpiry = null,   // ed.personalDetail.LicenseExpiry;
                MilitaryService = ed.personalDetail.MilitaryService,
                NickName = ed.personalDetail.NickName,
                Smokar = ed.personalDetail.Smoker,
            };

            newEmp.PersonalDetails.Add(epd);

            this._dbContext.Employees.Add(newEmp);
            this._dbContext.SaveChanges();

            return Ok();
        }
    }
}
