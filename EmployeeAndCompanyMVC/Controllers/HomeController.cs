using Microsoft.AspNetCore.Mvc;

namespace EmployeeAndCompanyMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
