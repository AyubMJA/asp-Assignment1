using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using assignment1.Data;
using assignment1.Models;

namespace assignment1.Controllers
{
    public class CarsController : Controller
    {
        private readonly assignment1Context _context;

        public CarsController(assignment1Context context)
        {
            _context = context;
        }

        // GET: Cars
        public async Task<IActionResult> Index()
        {
            return View(await _context.Car.ToListAsync());
        }

        // GET: Cars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return View("Error");
            }

            var car = await _context.Car
                .FirstOrDefaultAsync(m => m.ID == id);
            if (car == null)
            {
                return View("Error",
                    new ErrorViewModel
                    { 
                        RequestId = id.ToString(),
                        Description = $"Unable to find car with id={id}."
                    });
            }

            return View(car);
        }

        // GET: Cars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Make,Model,Colour,Year,PurchaseDate,Kilometers")] Car car)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(car);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(car);
            }
            catch (Exception ex)
            {
                return View("Error",
                    new ErrorViewModel
                    {
                        RequestId = "0",
                        Description = $"Exception message: {ex.Message}."
                    }   );
            }
            
            
        }

        // GET: Cars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return View();
            }

            var car = await _context.Car.FindAsync(id);
            if (car == null)
            {
                return View("Error", 
                    new ErrorViewModel 
                    { 
                        RequestId = id.ToString(),
                        Description = $"Unable to edit car with id={id}."
                    });
            }
            return View(car);
        }

        // POST: Cars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Make,Model,Colour,Year,PurchaseDate,Kilometers")] Car car)
        {
            if (id != car.ID)
            {
                return View();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(car);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarExists(car.ID))
                    {
                        return View();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }

        // GET: Cars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return View();
            }

            var car = await _context.Car
                .FirstOrDefaultAsync(m => m.ID == id);
            if (car == null)
            {
                return View("Error",
                    new ErrorViewModel
                    {
                        RequestId = id.ToString(),
                        Description=$"Unable to delete car with id:{id}."
                    });
            }

            return View(car);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var car = await _context.Car.FindAsync(id);
            _context.Car.Remove(car);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarExists(int id)
        {
            return _context.Car.Any(e => e.ID == id);
        }
    }
}
