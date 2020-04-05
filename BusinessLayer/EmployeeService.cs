using DataAccessLayer.Context;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _employeeRepository;

        public EmployeeService()
        {
            _employeeRepository = new EmployeeRepository();
        }
        public List<Employee> GetEmployees()
        {
            try
            {
                return _employeeRepository.GetEmployees().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Employee SaveEmployee(Employee education)
        {
            try
            {
                return _employeeRepository.SaveEmployee(education);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
