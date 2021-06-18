using EXAMEN.Data;
using EXAMEN.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXAMEN.Controllers
{
    public class IdentifController : Controller 
    {
        private readonly ApplicationDbContext db;

        public IdentifController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Index(string search)
        {
            if (search==null)
            {
                return View(await db.Identifs.ToListAsync());
            }
            return View(await db.Identifs.Where(s => s.IdentificacionNombre.Contains(search)).ToListAsync());


        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var band = await db.Identifs.FirstOrDefaultAsync(m => m.IdentificacionId == id);

            if (band == null)
            {
                return NotFound();
            }
            return View(band);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Identif identif)
        {
            if (ModelState.IsValid)
            {
                db.Add(identif);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(identif);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var band = await db.Identifs.FindAsync(id);

            if (band == null)
            {
                return NotFound();
            }
            return View(band);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id, Identif identif)
        {
            if (id != identif.IdentificacionId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(identif);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(identif);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var band = await db.Identifs.FirstOrDefaultAsync(m => m.IdentificacionId == id);

            if (band == null)
            {
                return NotFound();
            }
            return View(band);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Delete(int id)
        {
            var band = await db.Identifs.FindAsync(id);
            db.Identifs.Remove(band);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
