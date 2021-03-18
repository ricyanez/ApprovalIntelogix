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
    public class UserStepsController : Controller
    {
        private readonly ApprovalIntelogixContext _context;

        public UserStepsController(ApprovalIntelogixContext context)
        {
            _context = context;
        }

        // GET: UserSteps
        public async Task<IActionResult> Index()
        {
            var approvalIntelogixContext = _context.UserStep.Include(u => u.IdStepNavigation).Include(u => u.Pk);
            return View(await approvalIntelogixContext.ToListAsync());
        }

        // GET: UserSteps/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userStep = await _context.UserStep
                .Include(u => u.IdStepNavigation)
                .Include(u => u.Pk)
                .FirstOrDefaultAsync(m => m.IdUserStep == id);
            if (userStep == null)
            {
                return NotFound();
            }

            return View(userStep);
        }

        // GET: UserSteps/Create
        public IActionResult Create()
        {
            ViewData["IdStep"] = new SelectList(_context.Step, "IdStep", "IdStep");
            ViewData["PkId"] = new SelectList(_context.ApprovalUser, "PkId", "PkId");
            return View();
        }

        // POST: UserSteps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUserStep,PkId,IdStep")] UserStep userStep)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userStep);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdStep"] = new SelectList(_context.Step, "IdStep", "IdStep", userStep.IdStep);
            ViewData["PkId"] = new SelectList(_context.ApprovalUser, "PkId", "PkId", userStep.PkId);
            return View(userStep);
        }

        // GET: UserSteps/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userStep = await _context.UserStep.FindAsync(id);
            if (userStep == null)
            {
                return NotFound();
            }
            ViewData["IdStep"] = new SelectList(_context.Step, "IdStep", "IdStep", userStep.IdStep);
            ViewData["PkId"] = new SelectList(_context.ApprovalUser, "PkId", "PkId", userStep.PkId);
            return View(userStep);
        }

        // POST: UserSteps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdUserStep,PkId,IdStep")] UserStep userStep)
        {
            if (id != userStep.IdUserStep)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userStep);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserStepExists(userStep.IdUserStep))
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
            ViewData["IdStep"] = new SelectList(_context.Step, "IdStep", "IdStep", userStep.IdStep);
            ViewData["PkId"] = new SelectList(_context.ApprovalUser, "PkId", "PkId", userStep.PkId);
            return View(userStep);
        }

        // GET: UserSteps/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userStep = await _context.UserStep
                .Include(u => u.IdStepNavigation)
                .Include(u => u.Pk)
                .FirstOrDefaultAsync(m => m.IdUserStep == id);
            if (userStep == null)
            {
                return NotFound();
            }

            return View(userStep);
        }

        // POST: UserSteps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var userStep = await _context.UserStep.FindAsync(id);
            _context.UserStep.Remove(userStep);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserStepExists(string id)
        {
            return _context.UserStep.Any(e => e.IdUserStep == id);
        }
    }
}
