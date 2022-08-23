using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace GainsIndex.Controllers
{
    public class ExerciseController : Controller
    {
        private readonly Context _context;

        public ExerciseController(Context context)
        {
            _context = context;
        }

        // GET: Exercise
        [Authorize]
        public async Task<IActionResult> Index()
        {
              return _context.Exercises != null ? 
                          View(await _context.Exercises.ToListAsync()) :
                          Problem("Entity set 'Context.Exercises'  is null.");
        }

        // Work Out Index - Home Page
        [Authorize]
        public async Task<IActionResult> Home()
        {
              return _context.Exercises != null ? 
                          View(await _context.Exercises.ToListAsync()) :
                          Problem("Entity set 'Context.Exercises'  is null.");
        }

        // GET: Exercise/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Exercises == null)
            {
                return NotFound();
            }

            var exercise = await _context.Exercises
                .FirstOrDefaultAsync(m => m.id == id);
            if (exercise == null)
            {
                return NotFound();
            }

            return View(exercise);
        }

        // GET: Exercise/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Exercise/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,exercise_name,details,ww_bella,ww_geo,log_bella,log_geo,target_muscle,sets,reps,motion_group,body_focus,exercise_type,bella_monday,bella_tuesday,bella_wednesday,bella_thursday,bella_friday,bella_weekend,geo_monday,geo_tuesday,geo_wednesday,geo_thursday,geo_friday,geo_weekend")] Exercise exercise)
        {
            if (ModelState.IsValid)
            {
                _context.Add(exercise);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(exercise);
        }

        // GET: Exercise/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Exercises == null)
            {
                return NotFound();
            }

            var exercise = await _context.Exercises.FindAsync(id);
            if (exercise == null)
            {
                return NotFound();
            }
            return View(exercise);
        }

        // POST: Exercise/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,exercise_name,details,ww_bella,ww_geo,log_bella,log_geo,target_muscle,sets,reps,motion_group,body_focus,exercise_type,bella_monday,bella_tuesday,bella_wednesday,bella_thursday,bella_friday,bella_weekend,geo_monday,geo_tuesday,geo_wednesday,geo_thursday,geo_friday,geo_weekend")] Exercise exercise)
        {
            if (id != exercise.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exercise);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExerciseExists(exercise.id))
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
            return View(exercise);
        }

        // GET: Exercise/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Exercises == null)
            {
                return NotFound();
            }

            var exercise = await _context.Exercises
                .FirstOrDefaultAsync(m => m.id == id);
            if (exercise == null)
            {
                return NotFound();
            }

            return View(exercise);
        }

        // POST: Exercise/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Exercises == null)
            {
                return Problem("Entity set 'Context.Exercises'  is null.");
            }
            var exercise = await _context.Exercises.FindAsync(id);
            if (exercise != null)
            {
                _context.Exercises.Remove(exercise);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExerciseExists(int id)
        {
          return (_context.Exercises?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
