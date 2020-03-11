using DataAccessLayer.Context;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class SalaryComponentRepository
    {
        private readonly HrmsEntities _dbContext;

        public SalaryComponentRepository()
        {
            _dbContext = new HrmsEntities();
        }

        public IQueryable<SalaryComponentModel> GetSalaryComponentList()
        {
            return _dbContext.SalaryComponents
                .Select(x => new SalaryComponentModel
                {
                    SalaryComponentId = x.SalaryComponentId,
                    Name = x.Name,
                    Amount = x.Amount,
                    CostToCompany = x.CostToCompany,
                    Deduction = x.Deduction,
                    Earning = x.Earning,
                    Percentage = x.Percentage,
                    TotalPayable = x.TotalPayable,
                    OrganizationId = x.OrganizationId
                });
        }

        public SalaryComponentModel SaveSalaryComponent(SalaryComponentModel SalaryComponentModel)
        {
            var SalaryComponent = new SalaryComponent
            {
                Name = SalaryComponentModel.Name,
                Amount = SalaryComponentModel.Amount,
                CostToCompany = SalaryComponentModel.CostToCompany,
                Deduction = SalaryComponentModel.Deduction,
                Earning = SalaryComponentModel.Earning,
                Percentage = SalaryComponentModel.Percentage,
                TotalPayable = SalaryComponentModel.TotalPayable,
                OrganizationId = SalaryComponentModel.OrganizationId
            };

            _dbContext.SalaryComponents.Add(SalaryComponent);
            _dbContext.SaveChanges();

            SalaryComponentModel.SalaryComponentId = SalaryComponent.SalaryComponentId;
            return SalaryComponentModel;
        }

        public SalaryComponentModel UpdateSalaryComponent(SalaryComponentModel SalaryComponentModel)
        {
            var SalaryComponent = _dbContext.SalaryComponents
                .FirstOrDefault(x => x.SalaryComponentId == SalaryComponentModel.SalaryComponentId);
            if(SalaryComponent!=null)
            {
                SalaryComponent.Name = SalaryComponentModel.Name;
                SalaryComponent.Amount = SalaryComponentModel.Amount;
                SalaryComponent.CostToCompany = SalaryComponentModel.CostToCompany;
                SalaryComponent.Deduction = SalaryComponentModel.Deduction;
                SalaryComponent.Earning = SalaryComponentModel.Earning;
                SalaryComponent.Percentage = SalaryComponentModel.Percentage;
                SalaryComponent.TotalPayable = SalaryComponentModel.TotalPayable;
                SalaryComponent.OrganizationId = SalaryComponentModel.OrganizationId;
                _dbContext.SaveChanges();
            }

            return SalaryComponentModel;
        }

        public SalaryComponentModel DeleteSalaryComponent(long salaryComponentId)
        {
            var SalaryComponent = _dbContext.SalaryComponents
                .FirstOrDefault(x => x.SalaryComponentId == salaryComponentId);

            if(SalaryComponent!=null)
            {
                _dbContext.SalaryComponents.Remove(SalaryComponent);
                _dbContext.SaveChanges();
            }
            return new SalaryComponentModel();
        }

        public List<long> DeleteSalaryComponents(List<long> salaryComponentIds)
        {
            var SalaryComponents = _dbContext.SalaryComponents
                .Where(x => salaryComponentIds.Contains(x.SalaryComponentId))
                .ToList();
            if(SalaryComponents!=null && SalaryComponents.Count>0)
            {
                foreach(SalaryComponent SalaryComponent in SalaryComponents)
                {
                    _dbContext.SalaryComponents.Remove(SalaryComponent);
                    _dbContext.SaveChanges();
                }
            }
            return salaryComponentIds;
        }


    }
}
