using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace Hrms.Controllers
{
    [RoutePrefix("api/timezones")]
    public class TimeZoneController : ApiController
    {
        private readonly TimeZoneService _timeZoneService;

        public TimeZoneController()
        {
            _timeZoneService = new TimeZoneService();
        }

        [HttpGet]
        [Route("")]
        [ResponseType(typeof(IEnumerable<TimeZoneModel>))]
        public IHttpActionResult GetTimeZones()
        {
            try
            {
                return Ok(_timeZoneService.GetTimeZones());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("{timeZoneId}")]
        [ResponseType(typeof(IEnumerable<TimeZoneModel>))]
        public IHttpActionResult GetTimeZone(long timeZoneId)
        {
            try
            {
                return Ok(_timeZoneService.GetTimeZone(timeZoneId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
