using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class EmployeeSalaryManager : IEmployeeSalaryService
    {
        private IEmployeeSalaryDal _employeeSalaryDal;

        public EmployeeSalaryManager(IEmployeeSalaryDal employeeSalaryDal)
        {
            _employeeSalaryDal = employeeSalaryDal;
        }

        public void Add(EmployeeSalary employeeSalary)
        {
           _employeeSalaryDal.Add(employeeSalary);
        }

        public void Delete(EmployeeSalary employeeSalary)
        {
           _employeeSalaryDal.Delete(employeeSalary);
        }

        public List<EmployeeSalary> GetAll()
        {
            return _employeeSalaryDal.GetAll();
        }

        public List<EmployeeSalary> GetEmployeeSalarybySalary(decimal salary)
        {
            return _employeeSalaryDal.GetAll(es=>es.Salary==salary);
        }

        public void Update(EmployeeSalary employeeSalary)
        {
            _employeeSalaryDal.Update(employeeSalary);
        }
    }
}
