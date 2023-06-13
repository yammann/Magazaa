using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEmployeeSalaryService
    {
        void Add(EmployeeSalary employeeSalary);
        void Delete(EmployeeSalary employeeSalary);
        List<EmployeeSalary> GetAll();
        List<EmployeeSalary> GetEmployeeSalarybySalary(decimal salary);
        void Update(EmployeeSalary employeeSalary);
    }
}
