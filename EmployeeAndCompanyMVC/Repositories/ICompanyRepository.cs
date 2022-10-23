using EmployeeAndCompanyMVC.Models;

namespace EmployeeAndCompanyMVC.Repositories
{
    public interface ICompanyRepository
    {
        public List<Company> ShowAll();
        public Company GetCompanyById(int? id);
        public void Create(Company company);
        public void Update(Company company);
        public void Delete(int? id);
    }
}
