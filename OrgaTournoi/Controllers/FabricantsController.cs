using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrgaTournoi.Data;
using OrgaTournoi.Models;

namespace OrgaTournoi.Controllers
{
    public class FabricantsController : Controller
    {
        private readonly OrgaTournoiContext _context;

        public FabricantsController(OrgaTournoiContext context)
        {
            _context = context;
        }

        // GET: Fabricants
        public async Task<IActionResult> Index()
        {
              return View(await _context.Fabricant.ToListAsync());
        }

        // GET: Fabricants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Fabricant == null)
            {
                return NotFound();
            }

            var fabricant = await _context.Fabricant
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fabricant == null)
            {
                return NotFound();
            }

            return View(fabricant);
        }

        // GET: Fabricants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Fabricants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,Type,Siret,Directeur,Lien")] Fabricant fabricant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fabricant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fabricant);
        }

        // GET: Fabricants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Fabricant == null)
            {
                return NotFound();
            }

            var fabricant = await _context.Fabricant.FindAsync(id);
            if (fabricant == null)
            {
                return NotFound();
            }
            return View(fabricant);
        }

        // POST: Fabricants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Type,Siret,Directeur,Lien")] Fabricant fabricant)
        {
            if (id != fabricant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fabricant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FabricantExists(fabricant.Id))
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
            return View(fabricant);
        }

        // GET: Fabricants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Fabricant == null)
            {
                return NotFound();
            }

            var fabricant = await _context.Fabricant
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fabricant == null)
            {
                return NotFound();
            }

            return View(fabricant);
        }

        // POST: Fabricants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Fabricant == null)
            {
                return Problem("Entity set 'OrgaTournoiContext.Fabricant'  is null.");
            }
            var fabricant = await _context.Fabricant.FindAsync(id);
            if (fabricant != null)
            {
                _context.Fabricant.Remove(fabricant);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FabricantExists(int id)
        {
          return _context.Fabricant.Any(e => e.Id == id);
        }
    }
}
