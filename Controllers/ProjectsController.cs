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
using TMS.Models.ViewModels;
using static System.Net.Mime.MediaTypeNames;

namespace TMS.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment  _webHostEnvironment;


        public ProjectsController(DataContext context , IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;

        }
        //Get
        public IActionResult FindProject()
        {

            return View(new FindProject());
        }
        //Post
        [HttpPost]
        public IActionResult FindProject(FindProject model)
        {
            List<Project> SearchedFor = new List<Project>();
            model.Projects = _context.tblProjects.ToList();
            SearchedFor.AddRange( model.Projects.Where(p => p.Size ==model.Size));
            if(model.Name is not null)
                SearchedFor.AddRange(model.Projects.Where(p => p.Name.Contains(model.Name)));
            model.Projects = SearchedFor;
            return View(model);
        }
        // GET: Projects
        public async Task<IActionResult> Index()
        {
            return View(await _context.tblProjects.ToListAsync());
        }

        // GET: Projects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.tblProjects
                .FirstOrDefaultAsync(m => m.ProjectId == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // GET: Projects/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectId,Name,Size")] Project project, IFormFile Icon)
        {
            if (ModelState.IsValid)
            {
                if(Icon is not null)
                {
                    using (var stream = new MemoryStream())
                    {
                       await Icon.CopyToAsync(stream );

                        project.Icon = stream.ToArray();
                    }
                }

                else
                {
                    byte[] b = System.IO.File.ReadAllBytes("C:\\Users\\Dell\\Desktop\\aspCodes\\TMS\\wwwroot\\Images\\userprofile.png");
                    project.Icon = b.ToArray();
                }




                _context.Add(project);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }

        // GET: Projects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.tblProjects.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectId,Name,Size")] Project project , IFormFile Icon)
        {
            if (id != project.ProjectId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (Icon is not null)
                    {
                        using (var stream = new MemoryStream())
                        {
                            await Icon.CopyToAsync(stream);

                            project.Icon = stream.ToArray();
                        }
                    }
                    _context.Update(project);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectExists(project.ProjectId))
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
            return View(project);
        }

        // GET: Projects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.tblProjects
                .FirstOrDefaultAsync(m => m.ProjectId == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var project = await _context.tblProjects.FindAsync(id);
            _context.tblProjects.Remove(project);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectExists(int id)
        {
            return _context.tblProjects.Any(e => e.ProjectId == id);
        }
    }
}
