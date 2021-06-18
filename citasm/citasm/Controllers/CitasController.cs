using citasm.Data;
using citasm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace citasm.Controllers
{
    public class CitasController : Controller
    {

        private readonly ApplicationDbContext db;

        public CitasController(ApplicationDbContext db) 
        {
            this.db = db;
        }

        public async Task<IActionResult> Index()

        {

            return View(await db.Citas.ToListAsync());
        }


        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }


            var cit = await db.Citas.FirstOrDefaultAsync(d => d.citaId == id);
            if (cit == null)
            {
                return NotFound();
            }
            return View(cit);


        }












        public IActionResult Create()
        {

            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Cita cita)
        {
            if (ModelState.IsValid)
            {
                db.Add(cita);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(cita);

        }




        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var band = await db.Citas.FindAsync(id);

            if (band == null)
            {
                return NotFound();
            }


            return View(band);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Cita cita)
        {

            if (id != cita.citaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(cita);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {

                    return NotFound();
                }


                return RedirectToAction(nameof(Index));
            }

            return View(cita);
        }














        public async Task<IActionResult> Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }


            var cit = await db.Citas.FirstOrDefaultAsync(d => d.citaId == id);
            if (cit == null)
            {
                return NotFound();
            }
            return View(cit);


        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var band = await db.Citas.FindAsync(id);
            db.Citas.Remove(band);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
