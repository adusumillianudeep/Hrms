using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace Hrms.Controllers
{
    [RoutePrefix("api/salarycomponent")]
    public class SalaryComponentController : ApiController
    {
        private readonly SalaryComponentService _salaryComponentService;

        public SalaryComponentController()
        {
            _salaryComponentService = new SalaryComponentService();
        }

        [HttpGet]
        [Route("GetSalaryComponentList")]
        [ResponseType(typeof(IEnumerable<SalaryComponentModel>))]
        public IHttpActionResult GetSalaryComponentList()
        {
            try
            {
                return Ok(_salaryComponentService.GetSalaryComponentList());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("GetSalaryComponentById")]
        [ResponseType(typeof(IEnumerable<SalaryComponentModel>))]
        public IHttpActionResult GetSalaryComponentById(long salaryComponentId)
        {
            try
            {
                return Ok(_salaryComponentService.GetSalaryComponentById(salaryComponentId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("SaveSalaryComponent")]
        [ResponseType(typeof(SalaryComponentModel))]
        public IHttpActionResult SaveSalaryComponent(SalaryComponentModel salaryComponent)
        {
            try
            {
                return Ok(_salaryComponentService.SaveSalaryComponent(salaryComponent));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        [HttpPut]
        [Route("UpdateSalaryComponent")]
        [ResponseType(typeof(SalaryComponentModel))]
        public IHttpActionResult UpdateSalaryComponent(SalaryComponentModel salaryComponentModel)
        {
            try
            {
                if (salaryComponentModel.SalaryComponentId <= 0)
                {
                    return BadRequest("Invalid SalaryComponent id");
                }

                return Ok(_salaryComponentService.UpdateSalaryComponent(salaryComponentModel));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        [Route("delete/{salaryComponentId}")]
        [ResponseType(typeof(SalaryComponentModel))]
        public IHttpActionResult DeleteSalaryComponent(long salaryComponentId)
        {
            try
            {
                return Ok(_salaryComponentService.DeleteSalaryComponent(salaryComponentId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("DeleteSalaryComponents")]
        [ResponseType(typeof(SalaryComponentModel))]
        public IHttpActionResult DeleteSalaryComponents(List<long> salaryComponentIds)
        {
            try
            {
                return Ok(_salaryComponentService.DeleteSalaryComponents(salaryComponentIds));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
