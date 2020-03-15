using BusinessLayer;
using DataAccessLayer.Context;
using Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace Hrms.Controllers
{
    [RoutePrefix("api/payGrade")]
    public class PayGradeController : ApiController
    {
        private readonly PayGradeService _payGradeService;

        public PayGradeController()
        {
            _payGradeService = new PayGradeService();
        }

        [HttpPost]
        [Route("AddPayGrade")]
        [ResponseType(typeof(PayGrade))]
        public IHttpActionResult AddPayGrade(string Name)
        {
            try
            {
                return Ok(_payGradeService.AddPayGrade(Name));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("GetCurrencies")]
        [ResponseType(typeof(IList<CurrencyModel>))]
        public IHttpActionResult GetCurrencies()
        {
            try
            {
                return Ok(_payGradeService.GetCurrencies());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("ListOfPayGrades")]
        [ResponseType(typeof(IList<PayGradeModel>))]
        public IHttpActionResult ListOfPayGrades()
        {
            try
            {
                return Ok(_payGradeService.ListOfPayGrades());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("AssignCurrencyToPayGrade")]
        [ResponseType(typeof(GradeCurrency))]
        public IHttpActionResult AssignCurrencyToPayGrade(int PayGradeId, int CurrencyID, decimal MinimumSalary, decimal MaximumSalary)
        {
            try
            {
                return Ok(_payGradeService.AssignCurrencyToPayGrade(PayGradeId, CurrencyID, MinimumSalary, MaximumSalary));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("EditPayGrade")]
        [ResponseType(typeof(PayGradeModel))]
        public IHttpActionResult EditPayGrade(int PayGradeId)
        {
            try
            {
                return Ok(_payGradeService.EditPayGrade(PayGradeId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("DeletePayGrade")]
        [ResponseType(typeof(PayGradeModel))]
        public IHttpActionResult DeletePayGrade(List<long> PayGradeIds)
        {
            try
            {
                return Ok(_payGradeService.DeletePayGrade(PayGradeIds));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
