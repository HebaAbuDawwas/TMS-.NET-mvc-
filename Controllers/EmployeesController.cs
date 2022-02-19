using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TMS.Data;
using TMS.Models;

namespace TMS.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EmployeesController(DataContext context , IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Employees
      

        public async Task<IActionResult> Index(int ? id)
        {
            if (id != null)
                return View(await _context.tblEmployees.Where(a => a.FeesPerDay >= id).ToListAsync());
            
                return View(await _context.tblEmployees.ToListAsync());
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.tblEmployees.Include(e => e.Employeeprojects).ThenInclude(a => a.Project)
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeId,Name,FeesPerDay,Photo")] Employee employee, IFormFile Photo)
        {
            if (ModelState.IsValid)
            {
                if(Photo is not null )
                {
                    var FullImageName = $"{_webHostEnvironment.WebRootPath}\\Images\\ {Path.GetFileName(Photo.FileName)}";
                    using (var stream  = new FileStream(FullImageName,FileMode.Create))
                    {
                        Photo.CopyTo(stream);
                        string relativeImagePath = $"/Images/{Path.GetFileName(Photo.FileName)}";
                        employee.Photo = relativeImagePath;
                    }
                }
                else
                {
                    var FullImageName = $"{_webHostEnvironment.WebRootPath}\\Images\\ {Path.GetFileName("employee2.jpg")}";
                    string relativeImagePath = $"/Images/{Path.GetFileName("employee2.jpg")}";
                    employee.Photo = relativeImagePath;
                }
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.tblEmployees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,Name,FeesPerDay")] Employee employee , IFormFile Photo)
        {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if(Photo is null)
                    {
                       
                            var FullImageName = $"{_webHostEnvironment.WebRootPath}\\Images\\ {Path.GetFileName("employee2.jpg")}";
                            string relativeImagePath = $"/Images/{Path.GetFileName("employee2.jpg")}";
                            employee.Photo = relativeImagePath;
                        
                    }
                    if (Photo is not null)
                    {
                        var FullImageName = $"{_webHostEnvironment.WebRootPath}\\Images\\ {Path.GetFileName(Photo.FileName)}";
                        using (var stream = new FileStream(FullImageName, FileMode.Create))
                        {
                            Photo.CopyTo(stream);
                            string relativeImagePath = $"/Images/{Path.GetFileName(Photo.FileName)}";
                            employee.Photo = relativeImagePath;
                        }
                    }

                    _context.Update(employee);



                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.EmployeeId))
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
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.tblEmployees
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.tblEmployees.FindAsync(id);
            _context.tblEmployees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.tblEmployees.Any(e => e.EmployeeId == id);
        }
    }
}
