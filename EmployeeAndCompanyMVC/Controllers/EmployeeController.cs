using Microsoft.AspNetCore.Mvc;
using EmployeeAndCompanyMVC.Models;
using EmployeeAndCompanyMVC.Repositories;
using EmployeeAndCompanyMVC.ViewModels;

namespace EmployeeAndCompanyMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IViewModel _viewModel;
        public EmployeeController(IEmployeeRepository employeeRepository, IViewModel viewModel)
        {
            _employeeRepository = employeeRepository;
            _viewModel = viewModel;
        }
        public IActionResult Index() => View();
        public IActionResult ShowAll() => View(_employeeRepository.ShowAll());

        [HttpGet]
        public IActionResult Create() => View(_viewModel);

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _employeeRepository.Create(employee);
            return RedirectToAction("ShowAll");
        }
    }
}
