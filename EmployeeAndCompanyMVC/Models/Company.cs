using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAndCompanyMVC.Models
{


    public class Company
    {
        [Required, Key]
        public int Id { get; set; }

        [Required, StringLength(32)]
        public string Name { get; set; }

        [Required,StringLength(32)]
        public string Country { get; set; }
    }
}
