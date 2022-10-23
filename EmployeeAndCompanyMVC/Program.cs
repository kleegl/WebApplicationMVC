using Microsoft.EntityFrameworkCore;
using EmployeeAndCompanyMVC.Models;
using EmployeeAndCompanyMVC.Repositories;
using EmployeeAndCompanyMVC.ViewModels;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString: "DefaultConnection"));
builder.Services.AddTransient<ICompanyRepository, CompanyRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<IViewModel, EmployeeCompanyViewModel>();

var app = builder.Build();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();