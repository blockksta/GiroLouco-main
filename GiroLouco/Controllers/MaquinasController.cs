using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GiroLouco.Data;
using GiroLouco.Models;

namespace GiroLouco.Controllers
{
    public class MaquinasController : Controller
    {
        private readonly dbContext _context;

        public MaquinasController(dbContext context)
        {
            _context = context;
        }

        // GET: Maquinas
        public async Task<IActionResult> Index()
        {
              return _context.Maquinas != null ? 
                          View(await _context.Maquinas.ToListAsync()) :
                          Problem("Entity set 'dbContext.Maquinas'  is null.");
        }

        // GET: Maquinas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Maquinas == null)
            {
                return NotFound();
            }

            var maquinas = await _context.Maquinas
                .FirstOrDefaultAsync(m => m.idmaquina == id);
            if (maquinas == null)
            {
                return NotFound();
            }

            return View(maquinas);
        }

        // GET: Maquinas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Maquinas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idmaquina,tipo,patrimonio,memoria")] Maquinas maquinas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(maquinas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(maquinas);
        }

        // GET: Maquinas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Maquinas == null)
            {
                return NotFound();
            }

            var maquinas = await _context.Maquinas.FindAsync(id);
            if (maquinas == null)
            {
                return NotFound();
            }
            return View(maquinas);
        }

        // POST: Maquinas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idmaquina,tipo,patrimonio,memoria")] Maquinas maquinas)
        {
            if (id != maquinas.idmaquina)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(maquinas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaquinasExists(maquinas.idmaquina))
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
            return View(maquinas);
        }

        // GET: Maquinas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Maquinas == null)
            {
                return NotFound();
            }

            var maquinas = await _context.Maquinas
                .FirstOrDefaultAsync(m => m.idmaquina == id);
            if (maquinas == null)
            {
                return NotFound();
            }

            return View(maquinas);
        }

        // POST: Maquinas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Maquinas == null)
            {
                return Problem("Entity set 'dbContext.Maquinas'  is null.");
            }
            var maquinas = await _context.Maquinas.FindAsync(id);
            if (maquinas != null)
            {
                _context.Maquinas.Remove(maquinas);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaquinasExists(int id)
        {
          return (_context.Maquinas?.Any(e => e.idmaquina == id)).GetValueOrDefault();
        }
    }
}
