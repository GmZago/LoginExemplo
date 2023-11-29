using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LoginPederneiras.Models;

namespace LoginPederneiras.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly Contexto _context;

        public FornecedorController(Contexto context)
        {
            _context = context;
        }

        // GET: Fornecedor
        public async Task<IActionResult> Index()
        {
              return _context.Fornecedor != null ? 
                          View(await _context.Fornecedor.ToListAsync()) :
                          Problem("Entity set 'Contexto.Fornecedor'  is null.");
        }

        // GET: Fornecedor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Fornecedor == null)
            {
                return NotFound();
            }

            var fornecedor = await _context.Fornecedor
                .FirstOrDefaultAsync(m => m.FornecedorId == id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        // GET: Fornecedor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Fornecedor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FornecedorId,FornecedorNome")] Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fornecedor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fornecedor);
        }

        // GET: Fornecedor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Fornecedor == null)
            {
                return NotFound();
            }

            var fornecedor = await _context.Fornecedor.FindAsync(id);
            if (fornecedor == null)
            {
                return NotFound();
            }
            return View(fornecedor);
        }

        // POST: Fornecedor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FornecedorId,FornecedorNome")] Fornecedor fornecedor)
        {
            if (id != fornecedor.FornecedorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fornecedor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FornecedorExists(fornecedor.FornecedorId))
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
            return View(fornecedor);
        }

        // GET: Fornecedor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Fornecedor == null)
            {
                return NotFound();
            }

            var fornecedor = await _context.Fornecedor
                .FirstOrDefaultAsync(m => m.FornecedorId == id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        // POST: Fornecedor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int FornecedorId)
        {
            if (_context.Fornecedor == null)
            {
                return Problem("Entity set 'Contexto.Fornecedor'  is null.");
            }
            var fornecedor = await _context.Fornecedor.FindAsync(FornecedorId);
            if (fornecedor != null)
            {
                _context.Fornecedor.Remove(fornecedor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FornecedorExists(int id)
        {
          return (_context.Fornecedor?.Any(e => e.FornecedorId == id)).GetValueOrDefault();
        }
    }
}
