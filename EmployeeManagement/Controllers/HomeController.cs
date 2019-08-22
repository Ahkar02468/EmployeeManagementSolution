using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    
    public class WelcomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public WelcomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        
        public ViewResult List()
        {
           var model =_employeeRepository.GetAllEmployees();
            return View("~/Views/Home/Index.cshtml",model);
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
