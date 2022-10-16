using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RGMousepads.Data;
using RGMousepads.Models;

namespace RGMousepads.Controllers
{
    public class MousepadsClassesController : Controller
    {
        private readonly RGMousepadsContext _context;

        public MousepadsClassesController(RGMousepadsContext context)
        {
            _context = context;
        }

        // GET: MousepadsClasses
        public async Task<IActionResult> Index()
        {
            return View(await _context.MousepadsClass.ToListAsync());
        }

        // GET: MousepadsClasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mousepadsClass = await _context.MousepadsClass
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mousepadsClass == null)
            {
                return NotFound();
            }

            return View(mousepadsClass);
        }

        // GET: MousepadsClasses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MousepadsClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Brand,Size,color,shape,ModelNumber,Review")] MousepadsClass mousepadsClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mousepadsClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mousepadsClass);
        }

        // GET: MousepadsClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mousepadsClass = await _context.MousepadsClass.FindAsync(id);
            if (mousepadsClass == null)
            {
                return NotFound();
            }
            return View(mousepadsClass);
        }

        // POST: MousepadsClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Brand,Size,color,shape,ModelNumber,Review")] MousepadsClass mousepadsClass)
        {
            if (id != mousepadsClass.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mousepadsClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MousepadsClassExists(mousepadsClass.Id))
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
            return View(mousepadsClass);
        }

        // GET: MousepadsClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mousepadsClass = await _context.MousepadsClass
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mousepadsClass == null)
            {
                return NotFound();
            }

            return View(mousepadsClass);
        }

        // POST: MousepadsClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mousepadsClass = await _context.MousepadsClass.FindAsync(id);
            _context.MousepadsClass.Remove(mousepadsClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MousepadsClassExists(int id)
        {
            return _context.MousepadsClass.Any(e => e.Id == id);
        }
    }
}
