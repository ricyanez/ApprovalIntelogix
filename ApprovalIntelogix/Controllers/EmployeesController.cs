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
    public class EmployeesController : Controller
    {
        private readonly GeneralContext _context;

        public EmployeesController(GeneralContext context)
        {
            _context = context;
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
            var generalContext = _context.Employees.Include(e => e.IdPositionNavigation);
            return View(await generalContext.ToListAsync());
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employees = await _context.Employees
                .Include(e => e.IdPositionNavigation)
                .FirstOrDefaultAsync(m => m.IdEmployee == id);
            if (employees == null)
            {
                return NotFound();
            }

            return View(employees);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            ViewData["IdPosition"] = new SelectList(_context.JobPositions, "IdPosition", "IdPosition");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEmployee,IdPosition,IdPayRoll,NoEmp,Name,PLastName,MLastName,Email,Phone,Cellphone,Ad,Pic,PayRollRate,Status,Email2,Email3,IdDepartment,IdManager,AdmissionDate,Birthdate,Birthplace,Nss,Rfc,Curp,Infonavit,CtaBbva,MotherName,FatherName,IdGender,Address,IdCity,IdState,ZipCode,AddedBy,AddedDate,UpdatedBy,UpdatedDate,Fonacot,Pic2,IdBo,NameEm,PhoneEm,CellEm,RelationEm")] Employees employees)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employees);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPosition"] = new SelectList(_context.JobPositions, "IdPosition", "IdPosition", employees.IdPosition);
            return View(employees);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employees = await _context.Employees.FindAsync(id);
            if (employees == null)
            {
                return NotFound();
            }
            ViewData["IdPosition"] = new SelectList(_context.JobPositions, "IdPosition", "IdPosition", employees.IdPosition);
            return View(employees);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdEmployee,IdPosition,IdPayRoll,NoEmp,Name,PLastName,MLastName,Email,Phone,Cellphone,Ad,Pic,PayRollRate,Status,Email2,Email3,IdDepartment,IdManager,AdmissionDate,Birthdate,Birthplace,Nss,Rfc,Curp,Infonavit,CtaBbva,MotherName,FatherName,IdGender,Address,IdCity,IdState,ZipCode,AddedBy,AddedDate,UpdatedBy,UpdatedDate,Fonacot,Pic2,IdBo,NameEm,PhoneEm,CellEm,RelationEm")] Employees employees)
        {
            if (id != employees.IdEmployee)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employees);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeesExists(employees.IdEmployee))
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
            ViewData["IdPosition"] = new SelectList(_context.JobPositions, "IdPosition", "IdPosition", employees.IdPosition);
            return View(employees);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employees = await _context.Employees
                .Include(e => e.IdPositionNavigation)
                .FirstOrDefaultAsync(m => m.IdEmployee == id);
            if (employees == null)
            {
                return NotFound();
            }

            return View(employees);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var employees = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employees);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeesExists(string id)
        {
            return _context.Employees.Any(e => e.IdEmployee == id);
        }
    }
}
