using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace Hrms.Controllers.Admin.Organization
{
    [RoutePrefix("api/locations")]
    public class LocationController : ApiController
    {
        private readonly LocationService _locationService;

        public LocationController()
        {
            _locationService = new LocationService();
        }

        [HttpGet]
        [Route("")]
        [ResponseType(typeof(IEnumerable<LocationModel>))]
        public IHttpActionResult GetLocations()
        {
            try
            {
                return Ok(_locationService.GetLocations());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("~/api/locationsforpage")]
        [ResponseType(typeof(IEnumerable<LocationModel>))]
        public IHttpActionResult GetLocationsForPage(int pageNumber = 1, int itemsPerPage = 10, string sortField = "Id", string sortOrder = "DESC")
        {
            try
            {
                if (!(sortOrder == SortingService.SortByAscending || sortOrder == SortingService.SortByDescending))
                {
                    return BadRequest("Inavalid sort order");
                }

                return Ok(_locationService.GetLocationsForPage(pageNumber, itemsPerPage, sortField, sortOrder));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("{locationId}")]
        [ResponseType(typeof(LocationModel))]
        public IHttpActionResult GetLocation(long locationId)
        {
            try
            {
                return Ok(_locationService.GetLocation(locationId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        [ResponseType(typeof(LocationModel))]
        public IHttpActionResult SaveLocation(LocationModel location)
        {
            try
            {
                return Ok(_locationService.SaveLocation(location));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        [ResponseType(typeof(LocationModel))]
        public IHttpActionResult UpdateLocation(LocationModel location)
        {
            try
            {
                if (location.Id == null || location.Id <= 0)
                {
                    return BadRequest("Invalid location id");
                }

                return Ok(_locationService.UpdateLocation(location));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        [Route("")]
        [ResponseType(typeof(LocationModel))]
        public IHttpActionResult DeleteLocation(long locationId)
        {
            try
            {
                return Ok(_locationService.DeleteLocation(locationId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("deletelocations")]
        [ResponseType(typeof(LocationModel))]
        public IHttpActionResult DeleteLocations(List<long> locationIds)
        {
            try
            {
                return Ok(_locationService.DeleteLocations(locationIds));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("countrytimezone")]
        [ResponseType(typeof(CountryTimeZoneModel))]
        public IHttpActionResult GetCountryTimeZone()
        {
            try
            {
                return Ok(_locationService.GetCountryTimeZone());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
