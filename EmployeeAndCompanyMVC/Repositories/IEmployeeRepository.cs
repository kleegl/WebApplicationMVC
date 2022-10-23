﻿using EmployeeAndCompanyMVC.Models;

namespace EmployeeAndCompanyMVC.Repositories
{
    public interface IEmployeeRepository
    {
        public List<Employee> ShowAll();
        public Employee GetEmployeeById(int? id);
        public void Create(Employee employee);
        public void Edit(int? id);
        public void Delete(int? id);
    }
}
