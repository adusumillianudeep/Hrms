using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace Hrms.Controllers
{
    [RoutePrefix("api/countries")]
    public class CountryController : ApiController
    {
        private readonly CountryService _countryService;

        public CountryController()
        {
            _countryService = new CountryService();
        }

        [HttpGet]
        [Route("")]
        [ResponseType(typeof(IEnumerable<CountryModel>))]
        public IHttpActionResult GetCountries()
        {
            try
            {
                return Ok(_countryService.GetCountries());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("{countryId}")]
        [ResponseType(typeof(IEnumerable<CountryModel>))]
        public IHttpActionResult GetCountry(long countryId)
        {
            try
            {
                return Ok(_countryService.GetCountry(countryId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
