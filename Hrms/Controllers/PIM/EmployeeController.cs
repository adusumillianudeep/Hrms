using BusinessLayer;
using DataAccessLayer.Context;
using System;
using System.Web.Http;

namespace Hrms.Controllers.PIM
{
    [RoutePrefix("api/employee")]
    public class EmployeeController : ApiController
    {
        private readonly EmployeeService _service;

        public EmployeeController()
        {
            _service = new EmployeeService();
        }

        [HttpGet]
        [Route("GetEmployeeList")]
        public IHttpActionResult GetEmployeeList()
        {
            try
            {
                var employees = _service.GetEmployees();
                return Ok(employees);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("SaveEmployee")]
        public IHttpActionResult SaveEmployee(Employee employee)
        {
            try
            {
                var emp = _service.SaveEmployee(employee);
                return Ok(emp);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
