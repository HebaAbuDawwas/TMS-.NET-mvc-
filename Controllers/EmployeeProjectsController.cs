using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TMS.Data;
using TMS.Models;

namespace TMS.Controllers
{
    public class EmployeeProjectsController : Controller
    {
        private readonly DataContext _context;

        public EmployeeProjectsController(DataContext context)
        {
            _context = context;
        }

        // GET: EmployeeProjects
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.tblEmployeesProjects.Include(e => e.Employee).Include(e => e.Project);
            return View(await dataContext.ToListAsync());
        }

        // GET: EmployeeProjects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeProject = await _context.tblEmployeesProjects
                .Include(e => e.Employee)
                .Include(e => e.Project)
                .FirstOrDefaultAsync(m => m.EmployeeProjectId == id);
            if (employeeProject == null)
            {
                return NotFound();
            }

            return View(employeeProject);
        }

        // GET: EmployeeProjects/Create
        public IActionResult Create()
        {
            ViewData["EmployeeId"] = new SelectList(_context.tblEmployees, "EmployeeId", "Name");
            ViewData["ProjectId"] = new SelectList(_context.tblProjects, "ProjectId", "Name");
            return View();
        }

        // POST: EmployeeProjects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeProjectId,ProjectId,EmployeeId,StartDate,EndDate,Status")] EmployeeProject employeeProject)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeProject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeId"] = new SelectList(_context.tblEmployees, "EmployeeId", "Name", employeeProject.EmployeeId);
            ViewData["ProjectId"] = new SelectList(_context.tblProjects, "ProjectId", "Name", employeeProject.ProjectId);
            return View(employeeProject);
        }

        // GET: EmployeeProjects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeProject = await _context.tblEmployeesProjects.FindAsync(id);
            if (employeeProject == null)
            {
                return NotFound();
            }
            ViewData["EmployeeId"] = new SelectList(_context.tblEmployees, "EmployeeId", "Name", employeeProject.EmployeeId);
            ViewData["ProjectId"] = new SelectList(_context.tblProjects, "ProjectId", "Name", employeeProject.ProjectId);
            return View(employeeProject);
        }

        // POST: EmployeeProjects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeProjectId,ProjectId,EmployeeId,StartDate,EndDate,Status")] EmployeeProject employeeProject)
        {
            if (id != employeeProject.EmployeeProjectId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeProject);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeProjectExists(employeeProject.EmployeeProjectId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeId"] = new SelectList(_context.tblEmployees, "EmployeeId", "Name", employeeProject.EmployeeId);
            ViewData["ProjectId"] = new SelectList(_context.tblProjects, "ProjectId", "Name", employeeProject.ProjectId);
            return View(employeeProject);
        }

        // GET: EmployeeProjects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeProject = await _context.tblEmployeesProjects
                .Include(e => e.Employee)
                .Include(e => e.Project)
                .FirstOrDefaultAsync(m => m.EmployeeProjectId == id);
            if (employeeProject == null)
            {
                return NotFound();
            }

            return View(employeeProject);
        }

        // POST: EmployeeProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeProject = await _context.tblEmployeesProjects.FindAsync(id);
            _context.tblEmployeesProjects.Remove(employeeProject);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeProjectExists(int id)
        {
            return _context.tblEmployeesProjects.Any(e => e.EmployeeProjectId == id);
        }
    }
}
