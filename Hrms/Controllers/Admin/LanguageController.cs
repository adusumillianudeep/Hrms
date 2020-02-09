using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace Hrms.Controllers.Admin
{
    [RoutePrefix("api/languages")]
    public class LanguageController : ApiController
    {
        private readonly LanguageService _languageService;

        public LanguageController()
        {
            _languageService = new LanguageService();
        }

        [HttpGet]
        [Route("")]
        [ResponseType(typeof(IEnumerable<LanguageModel>))]
        public IHttpActionResult GetLanguages()
        {
            try
            {
                return Ok(_languageService.GetLanguages());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("~/api/languagesforpage")]
        [ResponseType(typeof(IEnumerable<LanguageModel>))]
        public IHttpActionResult GetLanguagesForPage(int pageNumber = 1, int itemsPerPage = 10, string sortField = "Id", string sortOrder = "DESC")
        {
            try
            {
                if (!(sortOrder == SortingService.SortByAscending || sortOrder == SortingService.SortByDescending))
                {
                    return BadRequest("Invalid sort order");
                }

                return Ok(_languageService.GetLanguagesForPage(pageNumber, itemsPerPage, sortField, sortOrder));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("{languageId}")]
        [ResponseType(typeof(LanguageModel))]
        public IHttpActionResult GetLanguage(long languageId)
        {
            try
            {
                return Ok(_languageService.GetLanguage(languageId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        [ResponseType(typeof(LanguageModel))]
        public IHttpActionResult SaveLanguage(LanguageModel language)
        {
            try
            {
                return Ok(_languageService.SaveLanguage(language));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        [ResponseType(typeof(LanguageModel))]
        public IHttpActionResult UpdateLanguage(LanguageModel language)
        {
            try
            {
                if (language.Id == null || language.Id <= 0)
                {
                    return BadRequest("Invalid language id");
                }

                return Ok(_languageService.UpdateLanguage(language));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        [Route("{languageId}")]
        [ResponseType(typeof(LanguageModel))]
        public IHttpActionResult DeleteLanguage(long languageId)
        {
            try
            {
                return Ok(_languageService.DeleteLanguage(languageId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("deletelanguages")]
        [ResponseType(typeof(LanguageModel))]
        public IHttpActionResult DeleteLanguages(List<long> languageIds)
        {
            try
            {
                return Ok(_languageService.DeleteLanguages(languageIds));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
