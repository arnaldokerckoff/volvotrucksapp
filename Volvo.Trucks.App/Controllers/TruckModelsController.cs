using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Volvo.Trucks.App.Models;

namespace Volvo.Trucks.App.Controllers
{
    public class TruckModelsController : Controller
    {
        private readonly VolvoTrucksContext _context;

        public TruckModelsController(VolvoTrucksContext context)
        {
            _context = context;
        }

        // GET: TruckModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.TruckModel.ToListAsync());
        }

        // GET: TruckModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var truckModel = await _context.TruckModel
                .SingleOrDefaultAsync(m => m.Id == id);
            if (truckModel == null)
            {
                return NotFound();
            }

            return View(truckModel);
        }

        // GET: TruckModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TruckModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description")] TruckModel truckModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(truckModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(truckModel);
        }

        // GET: TruckModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var truckModel = await _context.TruckModel.SingleOrDefaultAsync(m => m.Id == id);
            if (truckModel == null)
            {
                return NotFound();
            }
            return View(truckModel);
        }

        // POST: TruckModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description")] TruckModel truckModel)
        {
            if (id != truckModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(truckModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TruckModelExists(truckModel.Id))
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
            return View(truckModel);
        }

        // GET: TruckModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var truckModel = await _context.TruckModel
                .SingleOrDefaultAsync(m => m.Id == id);
            if (truckModel == null)
            {
                return NotFound();
            }

            return View(truckModel);
        }

        // POST: TruckModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var truckModel = await _context.TruckModel.SingleOrDefaultAsync(m => m.Id == id);
            _context.TruckModel.Remove(truckModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TruckModelExists(int id)
        {
            return _context.TruckModel.Any(e => e.Id == id);
        }
    }
}
