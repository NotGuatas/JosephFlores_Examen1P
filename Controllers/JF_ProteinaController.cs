using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JosephFlores_Examen1P.Data;
using JosephFlores_Examen1P.Models;

namespace JosephFlores_Examen1P.Controllers
{
    public class JF_ProteinaController : Controller
    {
        private readonly JosephFlores_Examen1PContext _context;

        public JF_ProteinaController(JosephFlores_Examen1PContext context)
        {
            _context = context;
        }

        // GET: JF_Proteina
        public async Task<IActionResult> Index()
        {
            return View(await _context.JF_Proteina.ToListAsync());
        }

        // GET: JF_Proteina/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jF_Proteina = await _context.JF_Proteina
                .FirstOrDefaultAsync(m => m.JFProteinaId == id);
            if (jF_Proteina == null)
            {
                return NotFound();
            }

            return View(jF_Proteina);
        }

        // GET: JF_Proteina/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JF_Proteina/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProteinaId,Name,Date,Precio,WheyProtein")] JF_Proteina jF_Proteina)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jF_Proteina);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jF_Proteina);
        }

        // GET: JF_Proteina/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jF_Proteina = await _context.JF_Proteina.FindAsync(id);
            if (jF_Proteina == null)
            {
                return NotFound();
            }
            return View(jF_Proteina);
        }

        // POST: JF_Proteina/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProteinaId,Name,Date,Precio,WheyProtein")] JF_Proteina jF_Proteina)
        {
            if (id != jF_Proteina.JFProteinaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jF_Proteina);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JF_ProteinaExists(jF_Proteina.JFProteinaId))
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
            return View(jF_Proteina);
        }

        // GET: JF_Proteina/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jF_Proteina = await _context.JF_Proteina
                .FirstOrDefaultAsync(m => m.JFProteinaId == id);
            if (jF_Proteina == null)
            {
                return NotFound();
            }

            return View(jF_Proteina);
        }

        // POST: JF_Proteina/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jF_Proteina = await _context.JF_Proteina.FindAsync(id);
            if (jF_Proteina != null)
            {
                _context.JF_Proteina.Remove(jF_Proteina);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JF_ProteinaExists(int id)
        {
            return _context.JF_Proteina.Any(e => e.JFProteinaId == id);
        }
    }
}
