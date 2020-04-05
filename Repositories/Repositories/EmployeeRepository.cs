using DataAccessLayer.Context;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class EmployeeRepository
    {
        private readonly HrmsEntities _dbContext;

        public EmployeeRepository()
        {
            _dbContext = new HrmsEntities();
        }

        public List<Employee> GetEmployees()
        {
            return _dbContext.Employees.ToList();
        }

        public Employee SaveEmployee(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
            return employee;
        }
    }
}
