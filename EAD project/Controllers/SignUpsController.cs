using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EAD_project;
using EAD_project.Models.Interface;

namespace EAD_project.Controllers
{
    public class SignUpsController : Controller
    {
        online_BookshopContext _context = new online_BookshopContext();
        private readonly ISignUp _signUp;
       

        public SignUpsController(ISignUp s)
        {
            
            _signUp = s;
        }

        // GET: SignUps
        public ViewResult signUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult signUp(SignUp signup)
        {


            if (ModelState.IsValid)
            {


                _signUp.checksignUp(signup);
                return Json("success");
            }
            else
            {
                return Json("fail");
            }
        }
        public async Task<IActionResult> Index()
        {
              return View(await _context.SignUps.ToListAsync());
        }

        // GET: SignUps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SignUps == null)
            {
                return NotFound();
            }

            var signUp = await _context.SignUps
                .FirstOrDefaultAsync(m => m.Id == id);
            if (signUp == null)
            {
                return NotFound();
            }

            return View(signUp);
        }

        // GET: SignUps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SignUps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,Email,Password,Creator,Modifier,Modifying_date,Creating_date")] SignUp signUp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(signUp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(signUp);
        }

        // GET: SignUps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SignUps == null)
            {
                return NotFound();
            }

            var signUp = await _context.SignUps.FindAsync(id);
            if (signUp == null)
            {
                return NotFound();
            }
            return View(signUp);
        }

        // POST: SignUps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserName,Email,Password,Creator,Modifier,Modifying_date,Creating_date")] SignUp signUp)
        {
            if (id != signUp.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(signUp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SignUpExists(signUp.Id))
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
            return View(signUp);
        }

        // GET: SignUps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SignUps == null)
            {
                return NotFound();
            }

            var signUp = await _context.SignUps
                .FirstOrDefaultAsync(m => m.Id == id);
            if (signUp == null)
            {
                return NotFound();
            }

            return View(signUp);
        }

        // POST: SignUps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SignUps == null)
            {
                return Problem("Entity set 'online_BookshopContext.SignUps'  is null.");
            }
            var signUp = await _context.SignUps.FindAsync(id);
            if (signUp != null)
            {
                _context.SignUps.Remove(signUp);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SignUpExists(int id)
        {
          return _context.SignUps.Any(e => e.Id == id);
        }
    }
}
