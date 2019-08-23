using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        
        public ViewResult Index()
        {
           var model =_employeeRepository.GetAllEmployees();
            return View(model);
        }

        
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModels homeDetailsViewModels = new HomeDetailsViewModels()
            {
                Employee = _employeeRepository.GetEmployees(id??1),
                PageTitle = "Employee details"
            };
            return View(homeDetailsViewModels);
        }
    }
}
