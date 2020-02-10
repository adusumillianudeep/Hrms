using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace Hrms.Controllers.Admin
{
    [RoutePrefix("api/costcenters")]
    public class CostCenterController : ApiController
    {
        private readonly CostCenterService _costCenterService;

        public CostCenterController()
        {
            _costCenterService = new CostCenterService();
        }

        [HttpGet]
        [Route("")]
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
        [Route("~/api/costcentersforpage")]
        [ResponseType(typeof(IEnumerable<CostCenter>))]
        public IHttpActionResult GetLocationsForPage(int pageNumber = 1, int itemsPerPage = 10, string sortField = "Id", string sortOrder = "DESC")
        {
            try
            {
                if (!(sortOrder == SortingService.SortByAscending || sortOrder == SortingService.SortByDescending))
                {
                    return BadRequest("Invalid sort order");
                }

                return Ok(_costCenterService.GetCostCentersForPage(pageNumber, itemsPerPage, sortField, sortOrder));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("{costCenterId}")]
        [ResponseType(typeof(CostCenter))]
        public IHttpActionResult GetCostCenterById(long costCenterId)
        {
            try
            {
                return Ok(_costCenterService.GetCostCenterById(costCenterId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
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
        [Route("")]
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
        [Route("{costCenterId}")]
        [ResponseType(typeof(CostCenter))]
        public IHttpActionResult DeleteCostCenter(long costCenterId)
        {
            try
            {
                return Ok(_costCenterService.DeleteCostCenter(costCenterId));
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
    }
}