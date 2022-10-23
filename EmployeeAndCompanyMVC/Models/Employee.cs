using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAndCompanyMVC.Models
{
    public enum WorkType
    {
        None,
        Engineering,
        Programming,
        Managment
    }
    public class Employee
    {
        [Required, Key]
        public int Id { get; set; }

        [Required, StringLength(32)]
        public string Name { get; set; }  
        
        public int Age { get; set; }

        [Required]
        public WorkType WorkType { get; set; }

        [Required]
        public Company Job { get; set; }
    }
}
