using Microsoft.AspNetCore.Mvc;
using EmployeeAndCompanyMVC.Models;
using EmployeeAndCompanyMVC.Repositories;
using EmployeeAndCompanyMVC.ViewModels;

namespace EmployeeAndCompanyMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly IViewModel _viewModel;
        public EmployeeController(
            IEmployeeRepository employeeRepository,
            ICompanyRepository companyRepository,
            IViewModel viewModel)
        {
            _employeeRepository = employeeRepository;
            _companyRepository = companyRepository;
            _viewModel = viewModel;
        }
        public IActionResult Index() => View();
        public IActionResult ShowAll() => View(_employeeRepository.ShowAll());

        [HttpGet]
        public IActionResult Create() => View(_viewModel);

        [HttpPost]
        public IActionResult Create(Employee employee, string companyName)
        {
            employee.Job = _companyRepository.GetCompanyByName(companyName);
            _employeeRepository.Create(employee);
            return RedirectToAction("ShowAll");
        }

        [HttpGet]
        public IActionResult EnumPage() => View();
        [HttpPost]
        public IActionResult EnumPage(Employee emp) => RedirectToAction("Index");
    }
}
