using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        void Add(Employee employee);
        void Delete(Employee employee);
        List<Employee> GetAll();
        List<Employee> GetEmployeebyEmployeeName(string employeeName);
        void Update(Employee employee);
    }
}
