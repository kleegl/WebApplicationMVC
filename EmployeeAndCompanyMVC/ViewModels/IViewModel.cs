using EmployeeAndCompanyMVC.Models;

namespace EmployeeAndCompanyMVC.ViewModels
{
    public interface IViewModel
    {
        public IEnumerable<Company> CompanyViewModel { get; set; }
        public IEnumerable<Employee> EmployeeViewModel { get; set; }
    }
}
