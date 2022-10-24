using EmployeeAndCompanyMVC.Models;

namespace EmployeeAndCompanyMVC.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly AppDbContext _context;
        public CompanyRepository(AppDbContext context)
        {
            _context = context;
        }
        
        public List<Company> ShowAll()
        {
            return _context.Companies.ToList();
        }

        public void Create(Company company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
        }

        public void Update(Company company)
        {
            try
            {
                _context.Companies.Update(company);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Delete(int? id)
        {
            try
            {
                Company? company = _context.Companies.FirstOrDefault(c => c.Id == id);
                _context.Companies.Remove(company);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public Company GetCompanyById(int? id)
        {
            try
            {
                Company? company = _context.Companies.FirstOrDefault(c => c.Id == id);
                return company;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Company GetCompanyByName(string? name)
        {
            try
            {
                Company company = _context.Companies.FirstOrDefault(c => c.Name == name);
                return company;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
