using EmployeeAndCompanyMVC.Models;

namespace EmployeeAndCompanyMVC.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Create(Employee employee)
        {
            try
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public void Edit(int? id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(int? id)
        {
            try
            {
                Employee employee = _context.Employees.FirstOrDefault(e => e.Id == id);
                return employee;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Employee> ShowAll()
        {
            try
            {
                return _context.Employees.ToList();

            }
            catch
            {
                throw;
            }
        }
    }
}
