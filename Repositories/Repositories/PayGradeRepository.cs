using DataAccessLayer.Context;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class PayGradeRepository
    {
        private readonly HrmsEntities _dbContext;

        public PayGradeRepository()
        {
            _dbContext = new HrmsEntities();
        }

        public PayGrade AddPayGrade(string Name)
        {
            PayGrade payGrade = new PayGrade
            {
                Name = Name
            };

            _dbContext.PayGrades.Add(payGrade);
            _dbContext.SaveChanges();

            return payGrade;
        }

        public IQueryable<CurrencyModel> GetCurrencies()
        {
            return _dbContext.Currencies
                .Select(x => new Model.CurrencyModel
                {
                    Id = x.Id,
                    Name = x.Name
                });
        }

        public IList<PayGradeModel> ListOfPayGrades()
        {
            return _dbContext.GetPayGrades()
                .Select(x => new PayGradeModel
                {
                    Id = x.PayGradeId,
                    Name = x.PayGrade,
                    Currency = x.Curreny
                }).ToList();
        }

        public GradeCurrency AssignCurrencyToPayGrade(int PayGradeId, int CurrencyID, decimal MinimumSalary, decimal MaximumSalary)
        {
            GradeCurrency gradeCurrency = new GradeCurrency
            {
                PayGradeId = PayGradeId,
                CurrencyID = CurrencyID,
                MaximumSalary = MaximumSalary,
                MinimumSalary = MinimumSalary
            };

            _dbContext.GradeCurrencies.Add(gradeCurrency);
            _dbContext.SaveChanges();

            return gradeCurrency;
        }

        public PayGradeModel EditPayGrade(int PayGradeId)
        {

            PayGrade payGrade = _dbContext.PayGrades.Where(x => x.Id == PayGradeId).FirstOrDefault();
            if (payGrade != null)
            {
                var gradeCurreny = _dbContext.GetPayGrades().Where(x => x.PayGradeId == PayGradeId).ToList();
                PayGradeModel payGradeModel = new PayGradeModel();

                payGradeModel.Name = payGrade.Name;
                payGradeModel.Id = payGrade.Id;

                GradeCurrencyModel gradeCurrencyModel = null;
                payGradeModel.GradeCurrencyModels = new List<GradeCurrencyModel>();
                foreach (var item in gradeCurreny)
                {
                    gradeCurrencyModel = new GradeCurrencyModel();
                    gradeCurrencyModel.Id = item.GradeCurrenyId;
                    gradeCurrencyModel.Currency = item.Curreny;
                    gradeCurrencyModel.MaximumSalary = item.MaximumSalary;
                    gradeCurrencyModel.MinimumSalary = item.MinimumSalary;
                    payGradeModel.GradeCurrencyModels.Add(gradeCurrencyModel);
                }

                return payGradeModel;
            }
            else
            {
                return new PayGradeModel();
            }
        }
        public List<long> DeletePayGrade(List<long> PayGradeIds)
        {
            var payGrades = _dbContext.PayGrades
                .Where(x => PayGradeIds.Contains(x.Id))
                .ToList();
            if (payGrades != null && payGrades.Count > 0)
            {
                foreach (PayGrade payGrade in payGrades)
                {
                    _dbContext.PayGrades.Remove(payGrade);
                    _dbContext.SaveChanges();
                }
            }
            var gradeCurrencies = _dbContext.GradeCurrencies
                .Where(x => PayGradeIds.Contains(x.PayGradeId))
                .ToList();
            if (gradeCurrencies != null && gradeCurrencies.Count > 0)
            {
                foreach (GradeCurrency gradeCurrency in gradeCurrencies)
                {
                    _dbContext.GradeCurrencies.Remove(gradeCurrency);
                    _dbContext.SaveChanges();
                }
            }
            return PayGradeIds;
        }

    }
}
