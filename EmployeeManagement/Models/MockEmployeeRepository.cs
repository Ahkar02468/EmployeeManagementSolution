using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employees> _employeelist;

        public MockEmployeeRepository()
        {
            _employeelist = new List<Employees>()
            {
                new Employees(){Id=1,Name="Mary",Department="HR",Email="mary@gmail.com" },
                new Employees(){Id=2,Name="John",Department="IT",Email="john@gmail.com" },
                new Employees(){Id=3,Name="Sam",Department="It",Email="sam@gmail.com" }
            };
        }
        public Employees GetEmployees(int Id)
        {
            return _employeelist.FirstOrDefault(e => e.Id == Id);
        }
    }
}
