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
    public class ApprovalUsersController : Controller
    {
        private readonly ApprovalIntelogixContext _context;

        public ApprovalUsersController(ApprovalIntelogixContext context)
        {
            _context = context;
        }

        // GET: ApprovalUsers
        public async Task<IActionResult> Index()
        {
            var approvalIntelogixContext = _context.ApprovalUser.Include(a => a.IdRoleNavigation);
            return View(await approvalIntelogixContext.ToListAsync());
        }

        // GET: ApprovalUsers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var approvalUser = await _context.ApprovalUser
                .Include(a => a.IdRoleNavigation)
                .FirstOrDefaultAsync(m => m.PkId == id);
            if (approvalUser == null)
            {
                return NotFound();
            }

            return View(approvalUser);
        }

        // GET: ApprovalUsers/Create
        public IActionResult Create()
        {
            ViewData["IdRole"] = new SelectList(_context.Role, "IdRole", "IdRole");
            return View();
        }

        // POST: ApprovalUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkId,IdUser,IdRole")] ApprovalUser approvalUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(approvalUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdRole"] = new SelectList(_context.Role, "IdRole", "IdRole", approvalUser.IdRole);
            return View(approvalUser);
        }

        // GET: ApprovalUsers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var approvalUser = await _context.ApprovalUser.FindAsync(id);
            if (approvalUser == null)
            {
                return NotFound();
            }
            ViewData["IdRole"] = new SelectList(_context.Role, "IdRole", "IdRole", approvalUser.IdRole);
            return View(approvalUser);
        }

        // POST: ApprovalUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PkId,IdUser,IdRole")] ApprovalUser approvalUser)
        {
            if (id != approvalUser.PkId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(approvalUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApprovalUserExists(approvalUser.PkId))
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
            ViewData["IdRole"] = new SelectList(_context.Role, "IdRole", "IdRole", approvalUser.IdRole);
            return View(approvalUser);
        }

        // GET: ApprovalUsers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var approvalUser = await _context.ApprovalUser
                .Include(a => a.IdRoleNavigation)
                .FirstOrDefaultAsync(m => m.PkId == id);
            if (approvalUser == null)
            {
                return NotFound();
            }

            return View(approvalUser);
        }

        // POST: ApprovalUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var approvalUser = await _context.ApprovalUser.FindAsync(id);
            _context.ApprovalUser.Remove(approvalUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApprovalUserExists(string id)
        {
            return _context.ApprovalUser.Any(e => e.PkId == id);
        }
    }
}
