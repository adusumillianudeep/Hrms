using Model;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class SalaryComponentService
    {
        private readonly SalaryComponentRepository _salaryComponentRepository;

        public SalaryComponentService()
        {
            _salaryComponentRepository = new SalaryComponentRepository();
        }

        public List<SalaryComponentModel> GetSalaryComponentList()
        {
            try
            {
                return _salaryComponentRepository.GetSalaryComponentList()
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SalaryComponentModel GetSalaryComponentById(long salaryComponentId)
        {
            try
            {
                return _salaryComponentRepository.GetSalaryComponentList()
                    .FirstOrDefault(x => x.SalaryComponentId == salaryComponentId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SalaryComponentModel SaveSalaryComponent(SalaryComponentModel salaryComponent)
        {
            try
            {
                return _salaryComponentRepository.SaveSalaryComponent(salaryComponent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SalaryComponentModel UpdateSalaryComponent(SalaryComponentModel salaryComponent)
        {
            try
            {
                return _salaryComponentRepository.UpdateSalaryComponent(salaryComponent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SalaryComponentModel DeleteSalaryComponent(long salaryComponentId)
        {
            try
            {
                return _salaryComponentRepository.DeleteSalaryComponent(salaryComponentId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<long> DeleteSalaryComponents(List<long> salaryComponentIds)
        {
            try
            {
                return _salaryComponentRepository.DeleteSalaryComponents(salaryComponentIds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
