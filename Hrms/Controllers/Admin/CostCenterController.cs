using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace Hrms.Controllers.Admin
{
    [RoutePrefix("api/costcenter")]
    public class CostCenterController : ApiController
    {
        private CostCenterService _costCenterService;

        public CostCenterController()
        {
            _costCenterService = new CostCenterService();
        }

        [HttpGet]
        [Route("getcostcenters")]
        [ResponseType(typeof(List<CostCenter>))]
        public IHttpActionResult GetCostCenters()
        {
            try
            {
                return Ok(_costCenterService.GetCostCenters());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("getcostcenterbyid/{id}")]
        [ResponseType(typeof(CostCenter))]
        public IHttpActionResult GetCostCenterById(long id)
        {
            try
            {
                return Ok(_costCenterService.GetCostCenterById(id));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("savecostcenter")]
        [ResponseType(typeof(CostCenter))]
        public IHttpActionResult SaveCostCenter(CostCenter costCenter)
        {
            try
            {
                return Ok(_costCenterService.SaveCostCenter(costCenter));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("updatecostcenter")]
        [ResponseType(typeof(CostCenter))]
        public IHttpActionResult UpdateCostCenter(CostCenter costCenter)
        {
            try
            {
                if (costCenter.Id == null || costCenter.Id <= 0)
                {
                    return BadRequest("Invalid cost center id");
                }

                return Ok(_costCenterService.UpdateCostCenter(costCenter));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        [Route("deletecostcenter/{id}")]
        [ResponseType(typeof(CostCenter))]
        public IHttpActionResult DeleteCostCenter(long id)
        {
            try
            {                
                return Ok(_costCenterService.DeleteCostCenter(id));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("deletecostcenters")]
        [ResponseType(typeof(CostCenter))]
        public IHttpActionResult DeleteCostCenters(List<long> ids)
        {
            try
            {
                return Ok(_costCenterService.DeleteCostCenters(ids));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // Use this endpoint if above (deletecostcenters) endpoint not works.
        [HttpPost]
        [Route("deletecostcentersmultiple")]
        [ResponseType(typeof(CostCenter))]
        public IHttpActionResult DeleteCostCentersMultiple(List<long> ids)
        {
            try
            {
                return Ok(_costCenterService.DeleteCostCentersMultiple(ids));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}