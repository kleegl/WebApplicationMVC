using Microsoft.EntityFrameworkCore;

namespace EmployeeAndCompanyMVC.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        
        private readonly IConfiguration _configuration;
        public AppDbContext(IConfiguration config)
        {
            _configuration = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
