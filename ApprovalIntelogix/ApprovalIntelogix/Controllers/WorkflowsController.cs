using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApprovalIntelogix.Models;

namespace ApprovalIntelogix.Controllers
{
    public class WorkflowsController : Controller
    {
        private readonly ApprovalIntelogixContext _context;

        public WorkflowsController(ApprovalIntelogixContext context)
        {
            _context = context;
        }

        // GET: Workflows
        public async Task<IActionResult> Index()
        {
            return View(await _context.Workflow.ToListAsync());
        }

        // GET: Workflows/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workflow = await _context.Workflow
                .FirstOrDefaultAsync(m => m.IdWorkflow == id);
            if (workflow == null)
            {
                return NotFound();
            }

            return View(workflow);
        }

        // GET: Workflows/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Workflows/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdWorkflow,Name,Description,Business")] Workflow workflow)
        {
            var guid = Guid.NewGuid().ToString();

            if (ModelState.IsValid)
            {
                string idworkflow = Guid.NewGuid().ToString();
                _context.Add(workflow);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(workflow);
        }

        // GET: Workflows/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workflow = await _context.Workflow.FindAsync(id);
            if (workflow == null)
            {
                return NotFound();
            }
            return View(workflow);
        }

        // POST: Workflows/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdWorkflow,Name,Description,Business")] Workflow workflow)
        {
            if (id != workflow.IdWorkflow)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(workflow);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkflowExists(workflow.IdWorkflow))
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
            return View(workflow);
        }

        // GET: Workflows/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workflow = await _context.Workflow
                .FirstOrDefaultAsync(m => m.IdWorkflow == id);
            if (workflow == null)
            {
                return NotFound();
            }

            return View(workflow);
        }

        // POST: Workflows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var workflow = await _context.Workflow.FindAsync(id);
            _context.Workflow.Remove(workflow);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkflowExists(string id)
        {
            return _context.Workflow.Any(e => e.IdWorkflow == id);
        }
    }
}
