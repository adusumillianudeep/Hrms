using DataAccessLayer.Context;
using Model;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PayGradeService
    {
        private readonly PayGradeRepository _payGradeRepository;

        public PayGradeService()
        {
            _payGradeRepository = new PayGradeRepository();
        }

        public PayGrade AddPayGrade(string Name)
        {
            try
            {
                return _payGradeRepository.AddPayGrade(Name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<CurrencyModel> GetCurrencies()
        {
            try
            {
                return _payGradeRepository.GetCurrencies().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<PayGradeModel> ListOfPayGrades()
        {
            try
            {
                return _payGradeRepository.ListOfPayGrades().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public GradeCurrency AssignCurrencyToPayGrade(int PayGradeId, int CurrencyID, decimal MinimumSalary, decimal MaximumSalary)
        {
            try
            {
                return _payGradeRepository.AssignCurrencyToPayGrade(PayGradeId,CurrencyID,MinimumSalary,MaximumSalary);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PayGradeModel EditPayGrade(int PayGradeId)
        {
            try
            {
                return _payGradeRepository.EditPayGrade(PayGradeId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<long> DeletePayGrade(List<long> PayGradeIds)
        {
            try
            {
                return _payGradeRepository.DeletePayGrade(PayGradeIds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
