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
    public class RequestsController : Controller
    {
        private readonly ApprovalIntelogixContext _context;

        public RequestsController(ApprovalIntelogixContext context)
        {
            _context = context;
        }

        // GET: Requests
        public async Task<IActionResult> Index()
        {
            var approvalIntelogixContext = _context.Request.Include(r => r.IdWorkflowNavigation);
            return View(await approvalIntelogixContext.ToListAsync());
        }

        // GET: Requests/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = await _context.Request
                .Include(r => r.IdWorkflowNavigation)
                .FirstOrDefaultAsync(m => m.IdRequest == id);
            if (request == null)
            {
                return NotFound();
            }

            return View(request);
        }

        // GET: Requests/Create
        public IActionResult Create()
        {
            ViewData["IdWorkflow"] = new SelectList(_context.Workflow, "IdWorkflow", "IdWorkflow");
            return View();
        }

        // POST: Requests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdRequest,Utilities,Amount,Currency,Description,Files1,Files2,IdWorkflow")] Request request)
        {
            if (ModelState.IsValid)
            {
                _context.Add(request);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdWorkflow"] = new SelectList(_context.Workflow, "IdWorkflow", "IdWorkflow", request.IdWorkflow);
            return View(request);
        }

        // GET: Requests/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = await _context.Request.FindAsync(id);
            if (request == null)
            {
                return NotFound();
            }
            ViewData["IdWorkflow"] = new SelectList(_context.Workflow, "IdWorkflow", "IdWorkflow", request.IdWorkflow);
            return View(request);
        }

        // POST: Requests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdRequest,Utilities,Amount,Currency,Description,Files1,Files2,IdWorkflow")] Request request)
        {
            if (id != request.IdRequest)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(request);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequestExists(request.IdRequest))
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
            ViewData["IdWorkflow"] = new SelectList(_context.Workflow, "IdWorkflow", "IdWorkflow", request.IdWorkflow);
            return View(request);
        }

        // GET: Requests/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = await _context.Request
                .Include(r => r.IdWorkflowNavigation)
                .FirstOrDefaultAsync(m => m.IdRequest == id);
            if (request == null)
            {
                return NotFound();
            }

            return View(request);

        }

        // POST: Requests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var request = await _context.Request.FindAsync(id);
            _context.Request.Remove(request);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequestExists(string id)
        {
            return _context.Request.Any(e => e.IdRequest == id);
        }
    }
}
