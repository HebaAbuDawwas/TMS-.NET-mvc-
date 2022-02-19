using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TMS.Data;
using TMS.Models;
using TMS.Models.ViewModels;

namespace TMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;

        public HomeController(ILogger<HomeController> logger , DataContext context)
        {

            _logger = logger;
            _context = context;
        }
       
        public IActionResult ShowProjectSummary()
        {
            ProjectSummary model = new ProjectSummary();
           
                model.Projects =  _context.tblProjects.Include(p => p.Employeeprojects).ThenInclude(a => a.Employee);
            
            return View("ProjectSummaryReport", model);

        }
        [HttpPost]
        public async Task<IActionResult> ShowProjectSummary(ProjectSummary model)
        {
            if(model.Name is null )
            {
                model.Projects=await _context.tblProjects.Include(p => p.Employeeprojects).ThenInclude(a => a.Employee).ToListAsync();
                return View("ProjectSummaryReport", model);

            }
            model.Projects = await _context.tblProjects.Where(p => p.Name.Contains(model.Name.ToLower())).Include(p=>p.Employeeprojects
                ).ThenInclude(a=>a.Employee).ToListAsync();
            return View("ProjectSummaryReport", model);
        }
        //-------------------------------------------------
        public IActionResult ShowEmployeeSummary()
        {
            EmployeeSummary model = new EmployeeSummary();

            model.Employees = _context.tblEmployees.Include(p => p.Employeeprojects).ThenInclude(a => a.Project);

            return View("EmployeeSummaryReport", model);

        }
        [HttpPost]
        public async Task<IActionResult> ShowEmployeeSummary(EmployeeSummary model)
        {
            if (model.Name is null)
            {
                model.Employees = await _context.tblEmployees.Include(p => p.Employeeprojects).ThenInclude(a => a.Project).ToListAsync();
                return View("EmployeeSummaryReport", model);

            }
            model.Employees = await _context.tblEmployees.Where(p => p.Name.Contains(model.Name.ToLower())).Include(p => p.Employeeprojects
                ).ThenInclude(a => a.Project).ToListAsync();
            return View("EmployeeSummaryReport", model);
        }
        public IActionResult Index(int id)
        {
            return View(id);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
