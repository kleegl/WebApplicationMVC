using EmployeeAndCompanyMVC.Models;
using EmployeeAndCompanyMVC.Repositories;

namespace EmployeeAndCompanyMVC.ViewModels
{
    public class EmployeeCompanyViewModel : IViewModel
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IEmployeeRepository _employeeRepository;

        public IEnumerable<Employee> EmployeeViewModel { get; set; } = new List<Employee>();
        public IEnumerable<Company> CompanyViewModel { get; set; } = new List<Company>();
        public Employee EmployeeVM { get; set; }

        public EmployeeCompanyViewModel(ICompanyRepository repository, IEmployeeRepository employeeRepository)
        {
            _companyRepository = repository;
            _employeeRepository = employeeRepository;

            CompanyViewModel = _companyRepository.ShowAll();
            EmployeeViewModel = employeeRepository.ShowAll();
        }
    }
}
