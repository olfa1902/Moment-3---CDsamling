using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Moment_3___CDsamling.Models;
using Moment_3___CDsamling.data;

namespace Moment_3___CDsamling.Controllers
{
    public class CDskivorController : Controller
    {
        private readonly CDContext _context;

        public CDskivorController(CDContext context)
        {
            _context = context;
        }

        // GET: CDskivor
        public async Task<IActionResult> Index()
        {
            return View(await _context.CDskivor.ToListAsync());
        }

        // GET: CDskivor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cDskivor = await _context.CDskivor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cDskivor == null)
            {
                return NotFound();
            }

            return View(cDskivor);
        }

        // GET: CDskivor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CDskivor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Artist,Album,Utgivning")] CDskivor cDskivor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cDskivor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); 
            }
            return View(cDskivor);
        }

        // GET: CDskivor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cDskivor = await _context.CDskivor.FindAsync(id);
            if (cDskivor == null)
            {
                return NotFound();
            }
            return View(cDskivor);
        }

        // POST: CDskivor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Artist,Album,Utgivning")] CDskivor cDskivor)
        {
            if (id != cDskivor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cDskivor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CDskivorExists(cDskivor.Id))
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
            return View(cDskivor);
        }

        // GET: CDskivor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cDskivor = await _context.CDskivor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cDskivor == null)
            {
                return NotFound();
            }

            return View(cDskivor);
        }

        // POST: CDskivor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cDskivor = await _context.CDskivor.FindAsync(id);
            _context.CDskivor.Remove(cDskivor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CDskivorExists(int id)
        {
            return _context.CDskivor.Any(e => e.Id == id);
        }
    }
}
