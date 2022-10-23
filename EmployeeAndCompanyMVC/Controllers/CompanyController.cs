using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using EmployeeAndCompanyMVC.Models;
using EmployeeAndCompanyMVC.Repositories;

namespace EmployeeAndCompanyMVC.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyRepository _companyRepository;
        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public IActionResult Index() => View();

        [HttpGet]
        public IActionResult ShowAll()
        {
            return View(_companyRepository.ShowAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Company company)
        {
            _companyRepository.Create(company);
            return RedirectToAction("ShowAll");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            Company company = _companyRepository.GetCompanyById(id);
            return View(company);
        }

        [HttpPost]
        public IActionResult Edit(Company company)
        {
            _companyRepository.Update(company);
            return RedirectToAction("ShowAll");
        }

        public IActionResult Delete(int? id)
        {
            _companyRepository.Delete(id);
            return RedirectToAction("ShowAll");
        }
    }
}
