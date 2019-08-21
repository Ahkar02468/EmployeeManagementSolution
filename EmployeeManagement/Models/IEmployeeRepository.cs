using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        Employees GetEmployees(int Id);
        IEnumerable<Employees> GetAllEmployees();
    }
}
