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
    public class StepsController : Controller
    {
        private readonly ApprovalIntelogixContext _context;

        public StepsController(ApprovalIntelogixContext context)
        {
            _context = context;
        }

        // GET: Steps
        public async Task<IActionResult> Index()
        {
            var approvalIntelogixContext = _context.Step.Include(s => s.IdWorkflowNavigation);
            return View(await approvalIntelogixContext.ToListAsync());
        }

        // GET: Steps/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var step = await _context.Step
                .Include(s => s.IdWorkflowNavigation)
                .FirstOrDefaultAsync(m => m.IdStep == id);
            if (step == null)
            {
                return NotFound();
            }

            return View(step);
        }

        // GET: Steps/Create
        public IActionResult Create()
        {
            ViewData["IdWorkflow"] = new SelectList(_context.Workflow, "IdWorkflow", "IdWorkflow");
            return View();
        }

        // POST: Steps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdStep,Namestep,Description,ApprovalCondition,Time,IdWorkflow")] Step step)
        {
            if (ModelState.IsValid)
            {
                _context.Add(step);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdWorkflow"] = new SelectList(_context.Workflow, "IdWorkflow", "IdWorkflow", step.IdWorkflow);
            return View(step);
        }

        // GET: Steps/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var step = await _context.Step.FindAsync(id);
            if (step == null)
            {
                return NotFound();
            }
            ViewData["IdWorkflow"] = new SelectList(_context.Workflow, "IdWorkflow", "IdWorkflow", step.IdWorkflow);
            return View(step);
        }

        // POST: Steps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdStep,Namestep,Description,ApprovalCondition,Time,IdWorkflow")] Step step)
        {
            if (id != step.IdStep)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(step);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StepExists(step.IdStep))
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
            ViewData["IdWorkflow"] = new SelectList(_context.Workflow, "IdWorkflow", "IdWorkflow", step.IdWorkflow);
            return View(step);
        }

        // GET: Steps/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var step = await _context.Step
                .Include(s => s.IdWorkflowNavigation)
                .FirstOrDefaultAsync(m => m.IdStep == id);
            if (step == null)
            {
                return NotFound();
            }

            return View(step);
        }

        // POST: Steps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var step = await _context.Step.FindAsync(id);
            _context.Step.Remove(step);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StepExists(string id)
        {
            return _context.Step.Any(e => e.IdStep == id);
        }
    }
}
